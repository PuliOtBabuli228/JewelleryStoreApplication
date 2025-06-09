using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.Service
{
    public interface ISearchablePage
    {
        void ApplySearch(string query);
    }
}
