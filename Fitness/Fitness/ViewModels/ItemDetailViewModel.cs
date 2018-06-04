using System;

using Fitness.Models;

namespace Fitness.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.ToestelNaam;
            Item = item;
        }
    }
}
