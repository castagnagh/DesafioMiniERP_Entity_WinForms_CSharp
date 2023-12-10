using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_Entity.DataModels
{
    public class ClienteProduto
    {

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId {  get; set; }
        public int QtdTotal { get; set; }
        public decimal PrecoTotal { get; set; }
        public DateTime Data {  get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
