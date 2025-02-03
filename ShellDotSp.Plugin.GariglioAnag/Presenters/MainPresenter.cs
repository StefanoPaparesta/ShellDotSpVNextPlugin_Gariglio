using System;
using System.Collections.Generic;
using System.Linq;
using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioAnag.Interfaces;
using ShellDotSp.Plugin.GariglioCore.Model;

namespace ShellDotSp.Plugin.GariglioAnag.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields

        public Dictionary<string, string> Pagine { get; set; }
            = new Dictionary<string, string>();
        public string PaginaCorrente { get; set; }
        private List<Anagrafica> _Anagrafiche;
        private Anagrafica _AnagraficaSelezionata;
        private VArticolo _ArticoloSelezionato;
        private Categoria _CategoriaSelezionata;
        private string _TipoAnagrafica;

        #endregion

        #region Ctor
        public MainPresenter(IMainView View)
            : base(View)
        {

        }
        #endregion

        #region Properties

        public List<Anagrafica> Anagrafiche
        {
            get
            {
                return _Anagrafiche;
            }
            set
            {
                _Anagrafiche = value;
            }
        }
        public List<VArticolo> Articoli { get; set; }
        public List<Categoria> Categorie { get; set; }

        public Anagrafica AnagraficaSelezionata
        {
            get { return _AnagraficaSelezionata; }
            set
            {

                _AnagraficaSelezionata = value;
                View.UpdateCurrentePage("anagraficaSelezionata");
            }
        }
        public VArticolo ArticoloSelezionato
        {
            get { return _ArticoloSelezionato; }
            set
            {

                _ArticoloSelezionato = value;
                View.UpdateCurrentePage("articoloSelezionato");
            }
        }
        public Categoria CategoriaSelezionata
        {
            get { return _CategoriaSelezionata; }
            set
            {

                _CategoriaSelezionata = value;
                View.UpdateCurrentePage("categoriaSelezionata");
            }
        }

        public string TipoAnagrafica
        {
            get { return _TipoAnagrafica; }
            set
            {
                _TipoAnagrafica = value;
                View.UpdateCurrentePage("tipoAnagrafica");
            }
        }

        #endregion

        #region IMainView

        protected override void CloseView(object sender, EventArgs e)
        {
            Dispose();
        }
        protected override void ViewInitialized(object sender, EventArgs e)
        {

        }

        #endregion

        #region Action

        internal void LoadAnagrafiche()
        {

            string sql = "FROM ANAGRAFICHE WHERE TIPO = @0 ORDER BY RAGIONESOCIALE";

            if (!string.IsNullOrEmpty(TipoAnagrafica))
            {
                Anagrafiche = Repository.Query<Anagrafica>(sql, TipoAnagrafica).ToList();
                View.UpdateCurrentePage("listaAnagrafiche");
            }

        }
        internal void ManageAnagrafica(Anagrafica Model)
        {

            if (Model.Id == 0)
            {
                Repository.Insert(Model);
            }
            else
            {
                Repository.Update(Model);
            }

        }
        internal void CancellaAnagrafica(Anagrafica Model)
        {

            Repository.Delete(Model);

        }

        internal void LoadArticoli()
        {


            string sql = "FROM vw_Articoli ORDER BY DescrizioneArticolo";
            Articoli = Repository.Query<VArticolo>(sql).ToList();
            View.UpdateCurrentePage("listaArticoli");


        }
        internal void ManageArticoli(Articolo Model)
        {

            if (Model.Id == 0)
            {
                Repository.Insert(Model);
            }
            else
            {
                Repository.Update(Model);
            }

        }
        internal void CancellaArticoli(VArticolo Model)
        {

            string sqlDelete = "DELETE FOM Articoli WHERE Id = @0";
            Repository.Execute(sqlDelete, Model.Id);

        }

        internal void LoadCategorie()
        {

            string sql = "FROM CATEGORIE WHERE TIPO = @0 ORDER BY DESCRIZIONE";

            Categorie = Repository.Query<Categoria>(sql, "ART").ToList();
            View.UpdateCurrentePage("listaCategorie");

        }
        internal void ManageCategoria(Categoria Model)
        {

            if (Model.Id == 0)
            {
                Repository.Insert(Model);
            }
            else
            {
                Repository.Update(Model);
            }

        }
        internal void CancellaCategoria(Categoria Model)
        {

            Repository.Delete(Model);

        }
        internal List<UnitaMisura> LoadUm(int Tipo)
        {
            return Repository.Query<UnitaMisura>("FROM UnitaMisura WHERE TipoUnita = @0", Tipo).ToList();
        }
        #endregion

    }
}
