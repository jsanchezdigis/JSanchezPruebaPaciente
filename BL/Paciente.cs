using ML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Paciente
    {
        public static ML.Result Add(ML.Paciente paciente)
        
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "PacienteAdd";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[7];

                        collection[0] = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = paciente.Nombre;

                        collection[1] = new SqlParameter("ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[1].Value = paciente.ApellidoPaterno;

                        collection[2] = new SqlParameter("ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = paciente.ApellidoMaterno;

                        collection[3] = new SqlParameter("FechaNacimiento", System.Data.SqlDbType.VarChar);
                        collection[3].Value = paciente.FechaNacimiento;

                        collection[4] = new SqlParameter("IdTipoSangre", System.Data.SqlDbType.VarChar);
                        collection[4].Value = paciente.TipoSangre.IdTipoSangre;

                        collection[5] = new SqlParameter("Sexo", System.Data.SqlDbType.VarChar);
                        collection[5].Value = paciente.Sexo;

                        collection[6] = new SqlParameter("Diagnostico", System.Data.SqlDbType.VarChar);
                        collection[6].Value = paciente.Diagnostico;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int RowAffected = cmd.ExecuteNonQuery();
                        if(RowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Se inserto el regristro";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al agregar el registro";
                
            }
            return result;
        }

        public static ML.Result Update(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "PacienteUpdate";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[8];

                        collection[0] = new SqlParameter("IdPaciente", System.Data.SqlDbType.VarChar);
                        collection[0].Value = paciente.IdPaciente;

                        collection[1] = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
                        collection[1].Value = paciente.Nombre;

                        collection[2] = new SqlParameter("ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = paciente.ApellidoPaterno;

                        collection[3] = new SqlParameter("ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[3].Value = paciente.ApellidoMaterno;

                        collection[4] = new SqlParameter("FechaNacimiento", System.Data.SqlDbType.VarChar);
                        collection[4].Value = paciente.FechaNacimiento;

                        collection[5] = new SqlParameter("IdTipoSangre", System.Data.SqlDbType.VarChar);
                        collection[5].Value = paciente.TipoSangre.IdTipoSangre;

                        collection[6] = new SqlParameter("Sexo", System.Data.SqlDbType.VarChar);
                        collection[6].Value = paciente.Sexo;

                        collection[7] = new SqlParameter("Diagnostico", System.Data.SqlDbType.VarChar);
                        collection[7].Value = paciente.Diagnostico;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int RowAffected = cmd.ExecuteNonQuery();
                        if (RowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Se actualizo el regristro";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al actualizar el registro";

            }
            return result;
        }

        public static ML.Result Delete(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "PacienteDelete";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdPaciente", System.Data.SqlDbType.VarChar);
                        collection[0].Value = paciente.IdPaciente;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int RowAffected = cmd.ExecuteNonQuery();
                        if (RowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Se actualizo el regristro";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al actualizar el registro";

            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    var query = "PacienteGetAll";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        DataTable TablaPaciente = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(TablaPaciente);

                        if (TablaPaciente.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in TablaPaciente.Rows)
                            {
                                ML.Paciente paciente = new ML.Paciente();

                                paciente.Nombre = row[0].ToString();
                                paciente.ApellidoPaterno = row[1].ToString();
                                paciente.ApellidoMaterno = row[2].ToString();
                                paciente.FechaNacimiento = row[3].ToString();
                                paciente.TipoSangre = new TipoSangre();
                                paciente.TipoSangre.IdTipoSangre = byte.Parse(row[4].ToString());
                                paciente.Sexo = row[5].ToString();
                                paciente.FechaIngreso = row[6].ToString();
                                paciente.Diagnostico = row[7].ToString();

                                result.Objects.Add(paciente);
                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Exception = ex;
                result.ErrorMessage = ex.Message;

            }
            return result;
        }

        public static ML.Result GetById(int IdPaciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "PacienteGetById";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdPaciente", System.Data.SqlDbType.VarChar);
                        collection[0].Value = IdPaciente;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();

                        DataTable TablaPaciente = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(TablaPaciente);

                        if (TablaPaciente.Rows.Count > 0)
                        {
                            result.Object = TablaPaciente.Rows[0];
                            foreach (DataRow row in TablaPaciente.Rows)
                            {
                                ML.Paciente paciente = new ML.Paciente();

                                paciente.Nombre = row[0].ToString();
                                paciente.ApellidoPaterno = row[1].ToString();
                                paciente.ApellidoMaterno = row[2].ToString();
                                paciente.FechaNacimiento = row[3].ToString();
                                paciente.TipoSangre = new TipoSangre();
                                paciente.TipoSangre.IdTipoSangre = byte.Parse(row[4].ToString());
                                paciente.Sexo = row[5].ToString();
                                paciente.FechaIngreso = row[6].ToString();
                                paciente.Diagnostico = row[7].ToString();

                                result.Object = paciente;
                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al actualizar el registro";

            }
            return result;
        }
    }
}
