using ACCESO_A_DATOS.DataBase;
using ENTIDADES.Personal;
using System;
using System.Data;

namespace LOGICA_DE_NEGOCIOS.Personal
{
    public class ClsPersonalLn
    {
        #region variables privadas
        private ClsDataBase objDataBase = null;
        #endregion

        #region Metodo index
        public void Index(ref ClsPersonal objPersonal)
        {
            objDataBase = new ClsDataBase();
            {
                //nombreTabla = "Personal",
                //nombreSP = "[SCH_General].(SP_¨Personal_Index)",
                //Scalar = false
            };
            Ejecutar(ref objPersonal);
        }
        #endregion

        #region CRUD Personal

        public void Create(ref ClsPersonal objPersonal)
        {
            objDataBase = new ClsDataBase();
            {
                //nombreTabla = "Personal",
                //nombreSP = "[SCH_General].(SP_¨Personal_Create)",
                //Scalar = true
            };
            objDataBase.DtParametros.Rows.Add(@"@Nombre", "17", objPersonal.NombrePersona);
            objDataBase.DtParametros.Rows.Add(@"@ApelMat", "17", objPersonal.ApelMat);
            objDataBase.DtParametros.Rows.Add(@"@ApelPat", "17", objPersonal.ApelPat);
            objDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "13", objPersonal.FechaNacimiento);

            Ejecutar(ref objPersonal);
        }
        public void Read(ref ClsPersonal objPersonal)
        {
            objDataBase = new ClsDataBase();
            {
                //nombreTabla = "Personal",
                //nombreSP = "[SCH_General].(SP_¨Personal_Read)",
                //Scalar = false
            };
            objDataBase.DtParametros.Rows.Add(@"@IdPersonal", "2", objPersonal.IdPersonal);

            Ejecutar(ref objPersonal);
        }
        public void Update(ref ClsPersonal objPersonal)
        {
            objDataBase = new ClsDataBase();
            {
                //nombreTabla = "Personal",
                //nombreSP = "[SCH_General].(SP_¨Personal_Update)",
                //Scalar = true
            };
            objDataBase.DtParametros.Rows.Add(@"@IdPersonal", "2", objPersonal.IdPersonal);
            objDataBase.DtParametros.Rows.Add(@"@Nombre", "17", objPersonal.NombrePersona);
            objDataBase.DtParametros.Rows.Add(@"@ApelMat", "17", objPersonal.ApelMat);
            objDataBase.DtParametros.Rows.Add(@"@ApelPat", "17", objPersonal.ApelPat);
            objDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "13", objPersonal.FechaNacimiento);

            Ejecutar(ref objPersonal);
        }
        public void Delete(ref ClsPersonal objPersonal)
        {
            objDataBase = new ClsDataBase();
            {
                //nombreTabla = "Personal",
                //nombreSP = "[SCH_General].(SP_¨Personal_Delete)",
                //Scalar = true
            };
            objDataBase.DtParametros.Rows.Add(@"@IdPersonal", "2", objPersonal.IdPersonal);
            Ejecutar(ref objPersonal);
        }

        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsPersonal objPersonal)
        {
            objDataBase.CRUD(ref objDataBase);

            if (objDataBase.MensajeErrorDB == null)
            {
                if (objDataBase.Scalar)
                {
                    objPersonal.ValorScalar = objDataBase.ValorScalar;
                }
                else
                {
                    objPersonal.DtResultados = objDataBase.DsResultado.Tables[0];
                    if (objPersonal.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in objPersonal.DtResultados.Rows)
                        {
                            objPersonal.IdPersonal = Convert.ToByte(item["IdPersonal"].ToString());
                            objPersonal.NombrePersona = item["NombrePersona"].ToString();
                            objPersonal.ApelMat = item["ApelMat"].ToString();
                            objPersonal.ApelPat = item["ApelPat"].ToString();
                            objPersonal.FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                        }
                    }
                }
            }
            else
            {
                objPersonal.MensajeError = objDataBase.MensajeErrorDB;
            }
        }
        #endregion



    }
}
