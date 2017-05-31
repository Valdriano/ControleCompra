using System;
using ControleCompra.Storage.Interfaces;
using ControleCompra.Util;

namespace ControleCompra.Model.Entities
{
    public class Supermercado : ObservableBaseObject, IKeyObject
    {
        private int id;
        private string descricao;

        public int Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Descricao { get => descricao; set { descricao = value; OnPropertyChanged(); } }

        public string Key { get; set; }
    }
}
