using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENASA.models
{
    public class Inspec
    {
        String id;
        String apellidoNombre;
        String tu;

        public Inspec(string id, string apellidoNombre, string tu)
        {
            this.Id = id;
            this.ApellidoNombre = apellidoNombre;
            this.Tu = tu;
        }

        public string Id { get => id; set => id = value; }
        public string ApellidoNombre { get => apellidoNombre; set => apellidoNombre = value; }
        public string Tu { get => tu; set => tu = value; }
    }
}
