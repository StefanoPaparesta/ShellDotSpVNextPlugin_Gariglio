#region Using
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using DevExpress.Export.Xl;
using ShellDotSp.Plugin.GariglioCore.Util;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.Helpers
{
    /// <summary>
    /// Reference Devexpress.Data.vxx
    /// Reference Devexpress.Printing.vxx
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExportXls<T>
    {

        #region Fields
        private Dictionary<string, PropertyInfoXls> PropInfos =
            new Dictionary<string, PropertyInfoXls>();
        #endregion

        #region Ctor
        public ExportXls()
        {
            RecordType = typeof(T);
            InitStructure();
        }
        #endregion

        #region Properties

        public Type RecordType { get; }

        #endregion

        #region Method

        public void Write(IEnumerable<T> Rows, string FileName)
        {

            IXlExporter exporter = XlExport.CreateExporter(XlDocumentFormat.Xlsx);

            using (FileStream stream = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite))
            {

                using (IXlDocument document = exporter.CreateDocument(stream))
                {

                    using (IXlSheet sheet = document.CreateSheet())
                    {

                        sheet.Name = "Export";

                        WriteHeader(sheet);
                        WriteRowsData(sheet, Rows);

                        sheet.AutoFilterRange = sheet.DataRange;

                    }

                }

            }

        }

        private void WriteHeader(IXlSheet Sheet)
        {

            foreach (KeyValuePair<string, PropertyInfoXls> entry in PropInfos)
            {

                if (!entry.Value.Ignore)
                {

                    using (IXlColumn column = Sheet.CreateColumn())
                    {

                        if (!string.IsNullOrEmpty(entry.Value.NumberFormat))
                        {

                            bool isDateTime = entry.Value.PropertyType.Equals(typeof(DateTime));

                            var nullableType = Nullable.GetUnderlyingType(entry.Value.PropertyType);

                            if (nullableType != null)
                            {
                                isDateTime = nullableType.Equals(typeof(DateTime));
                            }

                            column.Formatting = XlCellFormatting.FromNetFormat(entry.Value.NumberFormat, isDateTime);

                        }

                        if (entry.Value.Width != 0)
                        {

                            column.WidthInPixels = entry.Value.Width;

                        }

                    }

                }

            }

            XlCellFormatting cellFormatting = new XlCellFormatting();
            cellFormatting.Font = new XlFont();
            cellFormatting.Font.Name = "Century Gothic";
            cellFormatting.Font.SchemeStyle = XlFontSchemeStyles.None;
            cellFormatting.Font.Bold = true;
            cellFormatting.Font.Color = XlColor.FromTheme(XlThemeColor.Light1, 0.0);
            cellFormatting.Fill = XlFill.SolidFill(XlColor.FromTheme(XlThemeColor.Accent2, 0.0));

            using (IXlRow row = Sheet.CreateRow())
            {

                foreach (KeyValuePair<string, PropertyInfoXls> entry in PropInfos)
                {

                    if (!entry.Value.Ignore)
                    {
                        using (IXlCell cell = row.CreateCell())
                        {

                            if (!string.IsNullOrEmpty(entry.Value.Description))
                            {
                                cell.Value = entry.Value.Description;
                            }
                            else
                            {
                                cell.Value = entry.Value.PropertyName;
                            }

                            cellFormatting.Alignment = XlCellAlignment.FromHV(XlHorizontalAlignment.Center, XlVerticalAlignment.Center);

                            cell.ApplyFormatting(cellFormatting);

                        }
                    }

                }

            }

        }

        private void WriteRowsData(IXlSheet Sheet, IEnumerable<T> Rows)
        {

            XlCellFormatting cellDetailFormatting = new XlCellFormatting();
            cellDetailFormatting.Border = XlBorder.AllBorders(XlColor.Auto);

            foreach (var row in Rows)
            {
                using (IXlRow xlsRow = Sheet.CreateRow())
                {
                    foreach (KeyValuePair<string, PropertyInfoXls> entry in PropInfos)
                    {

                        if (!entry.Value.Ignore)
                        {
                            using (IXlCell cell = xlsRow.CreateCell())
                            {

                                if (Nullable.GetUnderlyingType(row.GetType().GetProperty(entry.Value.PropertyName).PropertyType) != null)
                                {

                                    if (row.GetType().GetProperty(entry.Value.PropertyName).GetValue(row, null) != null)
                                    {

                                        object data = row.GetType().GetProperty(entry.Value.PropertyName).GetValue(row, null);
                                        cell.Value = XlVariantValue.FromObject(data);

                                    }
                                    else
                                    {
                                        //cell.Value = null;
                                        cell.Value = XlVariantValue.Empty;
                                    }

                                }
                                else
                                {
                                    object data = row.GetType().GetProperty(entry.Value.PropertyName).GetValue(row, null);
                                    cell.Value = XlVariantValue.FromObject(data);
                                }


                                var HAl = (XlHorizontalAlignment)Enum.Parse(typeof(XlHorizontalAlignment),
                                            entry.Value.RowHorizontallAlignment.ToString(),
                                            false);

                                var VAl = (XlVerticalAlignment)Enum.Parse(typeof(XlVerticalAlignment),
                                            entry.Value.RowVerticalAlignment.ToString(),
                                            false);

                                cellDetailFormatting.Alignment = XlCellAlignment.FromHV(HAl, VAl);

                                cell.ApplyFormatting(cellDetailFormatting);

                            }
                        }

                    }
                }
            }

        }

        private void InitStructure()
        {

            PropertyInfo[] propertyInfos;
            propertyInfos = typeof(T).GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                PropertyInfoXls propInfos = new PropertyInfoXls();

                propInfos.PropertyName = propertyInfo.Name;
                propInfos.PropertyType = propertyInfo.PropertyType;

                propInfos.Ignore = false;

                object[] attrs = propertyInfo.GetCustomAttributes(true);

                foreach (var item in attrs)
                {
                    if (item is XlsIgnoreAttribute)
                    {
                        propInfos.Ignore = true;
                    }

                    if (item is XlsRowAttribute)
                    {
                        var local = (XlsRowAttribute)item;
                        propInfos.RowHorizontallAlignment = local.HorizontallAlignment;
                        propInfos.RowVerticalAlignment = local.VerticalAlignment;
                        propInfos.NumberFormat = local.Style;
                    }

                    if (item is XlsColumnAttribute)
                    {
                        var local = (XlsColumnAttribute)item;
                        propInfos.Description = local.Description;
                        propInfos.Width = local.Width;
                        propInfos.HeaderHorizontallAlignment = local.HorizontallAlignment;
                        propInfos.HeaderVerticalAlignment = local.VerticalAlignment;
                    }
                }

                PropInfos.Add(propertyInfo.Name, propInfos);

            }
        }

        #endregion

    }

    public class PropertyInfoXls
    {

        public string PropertyName { get; set; }
        public Type PropertyType { get; set; }
        public string Description { get; set; }
        public int Width { get; set; }
        public string NumberFormat { get; set; }
        public bool Ignore { get; set; }

        public VerticalAlignment HeaderVerticalAlignment { get; set; }
        public HorizontalAlignment HeaderHorizontallAlignment { get; set; }

        public VerticalAlignment RowVerticalAlignment { get; set; }
        public HorizontalAlignment RowHorizontallAlignment { get; set; }

    }



}
