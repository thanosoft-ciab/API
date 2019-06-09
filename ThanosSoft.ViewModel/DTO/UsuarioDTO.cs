using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanosSoft.ViewModel.DTO
{
    public class UsuarioDTO
    {
        public string codUsuario { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
    }
}
