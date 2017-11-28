using System;
using System.Data;
using PrototipoEvaluaciones.Negocio;

namespace PrototipoEvaluaciones.Web
{
    public partial class Index : System.Web.UI.Page
    {
        private DataSet _sourceDataSet;

        protected void Page_Load(object sender, EventArgs e)
        {
            var proveedorEvaluaciones = new ProveedorEvaluaciones();
            _sourceDataSet = proveedorEvaluaciones.GetMockDataSetEvaluaciones();

            this.GridView1.DataSource = _sourceDataSet.Tables[0];
            GridView1.DataBind();
        }
    }
}