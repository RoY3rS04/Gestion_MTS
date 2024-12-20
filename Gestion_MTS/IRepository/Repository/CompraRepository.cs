﻿using Gestion_MTS.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.IRepository.Repository
{
    public class CompraRepository : IRepository<Compra>
    {
        private readonly string _connectionString;

        public CompraRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Compra compra)
        {
            string query = "EXEC InsertarCompra @numero_compra, @id_tipo_pago";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numero_compra", compra.NumeroCompra);
                command.Parameters.AddWithValue("@id_tipo_pago", compra.IdTipoPago);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Compra insertada exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar la compra: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from compras where id_compra = @id_compra";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_compra", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable tabla = new DataTable();

            string query = "Select * from ComprasView";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(tabla);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return tabla;
        }

        public void Update(Compra compra, int id)
        {
            string query = "EXEC ActualizarCompra @id_compra, @numero_compra, @fecha, @id_tipo_pago";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_compra", compra.IdCompra);
                command.Parameters.AddWithValue("@numero_compra", (object)compra.NumeroCompra ?? DBNull.Value);
                command.Parameters.AddWithValue("@fecha", (object)compra.Fecha ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_tipo_pago", (object)compra.IdTipoPago ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Compra actualizada exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar la compra: " + e.Message);
                }
            }
        }

        public int? GetIdCompra(int numeroCompra)
        {
            string query = "SELECT TOP 1 id_compra FROM compras WHERE numero_compra = @numeroCompra";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroCompra", numeroCompra);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int idCompra))
                    {
                        return idCompra;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al obtener el ID de la compra: " + e.Message);
                }
            }
        }

    }
}
