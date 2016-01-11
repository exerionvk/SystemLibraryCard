using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibraryCard
{
    public class Collection : IBibliographicDescription
    {
        private string _title;
        private string _details;
        private string _autor;
        private string _publisherImprint;
        private string _amountPages;
        public string resString;
        public Collection(string title, string details, string autor, string publisherImprint, string amountPages)
        {
            if (String.IsNullOrEmpty(title)) throw new BibliographicExeption("Поле Title не должно быть пустым");
            if (String.IsNullOrEmpty(details)) throw new BibliographicExeption("Поле Details не должно быть пустым");
            if (String.IsNullOrEmpty(autor)) throw new BibliographicExeption("Поле Autor не должно быть пустым");
            if (String.IsNullOrEmpty(publisherImprint)) throw new BibliographicExeption("Поле Publisher Imprint не должно быть пустым");
            if (String.IsNullOrEmpty(amountPages)) throw new BibliographicExeption("Поле Amount Pages не должно быть пустым");
            _title = title;
            _details = details;
            _autor = autor;
            _publisherImprint = publisherImprint;
            _amountPages = amountPages;
            resString = _title + ": (" + _details + ") / " + _autor + ". — " + _publisherImprint + ". — " + _amountPages + " с.";
        }
        public string Print
        {
            get { return resString; }
        }
    }
}
