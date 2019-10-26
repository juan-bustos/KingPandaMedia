using System.Collections.Generic;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models.ViewModels
{
    public class VideoViewModel : Portfolio
    {
        public IEnumerable<Portfolio> Video { get; set; }
    }
}
