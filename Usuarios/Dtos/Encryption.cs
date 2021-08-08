using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Dtos
{
    public class Encryption
    {
        
        
            /**
             *  Metodo: encriptar.
             *  Autor: Julián Méndez
             *  Retorno: Hash de contraseña.
             *  Descripción: Creación de Hash.
             * */
            public string encriptar(string PWD)
            {
                // Valida que la cadena tenga valor
                if (PWD != null && PWD != "")
                {
                    try
                    {
                        // se crea el hash de la cadena
                        string response = creaHash(PWD);

                        // se valida que la respuesta sea valida
                        if (response != "ERROR")
                        {
                            // se retorna la cadena
                            return response;
                        }

                    }
                    catch (Exception e)
                    {
                        // se retorna el error
                        return "ERROR: " + e;
                    }
                }
                return "ERROR";
            }

            public string creaHash(string PWD)
            {
                // Se valida la longitud de la cadena
                if (PWD.Length > 0)
                {
                    // Codificacion de la cadena
                    string salt = "PalabraC0dificar";
                    SHA512Managed HT = new SHA512Managed();
                    byte[] HAB = Encoding.UTF8.GetBytes(string.Concat(PWD, salt));
                    byte[] EB = HT.ComputeHash(HAB);
                    HT.Clear();
                    return Convert.ToBase64String(EB);
                }
                return "ERROR";
            }
        
    }
}
