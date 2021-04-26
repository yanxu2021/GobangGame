using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GobangGame.Models;

namespace GobangGame.Models.ViewModels
{
    public class RecordViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
