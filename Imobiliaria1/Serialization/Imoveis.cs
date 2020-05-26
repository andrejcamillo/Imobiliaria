using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria1.Serialization
{

    public class Imoveis
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Status { get; set; }
        public double Area_total { get; set; }
        public double Area_privativa { get; set; }
        public double Iptu { get; set; }
        public double Condominio { get; set; }
        public bool Planta { get; set; }
        public bool Dependencia { get; set; }
        public bool Sacada { get; set; }
        public bool Portaria { get; set; }
        public bool Elevador { get; set; }
        public string Churrasqueira { get; set; }
        public int Dormitorios { get; set; }
        public int Suites { get; set; }
        public int Vagas { get; set; }
        public int Banheiros { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Descricao { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Valor_venda { get; set; }
        public bool Mostrar_mapa { get; set; }
        public string Imagem_principal { get; set; }
        public string [] Imagens { get; set; }

           
        }
    }

