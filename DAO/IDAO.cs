using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal interface IDAO
    {
        DataTable all();
        Object create(object objeto);
        Object read(object chave);
        Object update(object objeto);
        Object delete(object chave);



    }
}
