using System;
using System.Data;

namespace PrototipoEvaluaciones.Negocio
{
    public class ProveedorEvaluaciones
    {
        public DataSet GetMockDataSetEvaluaciones()
        {
            var dataSet = new System.Data.DataSet();
            DataTable tableEvaluaciones = new DataTable("evaluaciones");
            tableEvaluaciones.Columns.Add("nombreEvaluacion");
            tableEvaluaciones.Columns.Add("fechaEvaluacion");
            tableEvaluaciones.Columns.Add("operacion");

            for (int i = 0; i < 10; i++)
            {
                tableEvaluaciones.Rows.Add($"evaluacion{i}", DateTime.Now.AddDays(-i), $"operacion{i}");
            }

            dataSet.Tables.Add(tableEvaluaciones);
            return dataSet;
        }
    }
}
