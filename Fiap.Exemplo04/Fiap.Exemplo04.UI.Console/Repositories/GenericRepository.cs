using Fiap.Exemplo04.UI.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.UI.Console.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public T BuscarPorId(int id)
        {
            T entidade = null;

            using (var e = new HttpClient())
            {
                e.BaseAddress = new Uri("http://localhost:58692/");
                e.DefaultRequestHeaders.Accept.Clear();
                e.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = e.GetAsync("api/aluno/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    entidade =
                    response.Content.ReadAsAsync<T>().Result;
                }
            }
            return entidade as T;
        }

        public void Cadastrar(T entidade)
        {
            using (var e = new HttpClient())
            {
                e.BaseAddress = new Uri("http://localhost:58692/");
                HttpResponseMessage response =
                e.PostAsJsonAsync("api/aluno", entidade).Result;
                if (response.IsSuccessStatusCode)
                {
                    Uri uri = response.Headers.Location;
                }
                else
                {
                    System.Console.WriteLine("Erro: A API retornou HTTP código " + response.StatusCode);
                }
            }
        }

        public ICollection<T> Listar()
        {
            IEnumerable<T> entidades = null;

            using (var e = new HttpClient())
            {
                e.BaseAddress = new Uri("http://localhost:58692/");
                e.DefaultRequestHeaders.Accept.Clear();
                e.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = e.GetAsync("api/aluno/").Result;
                if (response.IsSuccessStatusCode)
                {
                    entidades =
                    response.Content.ReadAsAsync<IEnumerable<T>>().Result;
                }
            }
            return entidades as ICollection<T>;
        }
    }
}