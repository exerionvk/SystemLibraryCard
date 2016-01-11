using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibraryCard
{
    public class Dissertation : IBibliographicDescription
    {
        private string _title;
        private string _details;
        private string _autor;
        private string _dateProtection;
        private string _dateApproved;
        private string _amountPages;
        public string resString;
        public Dissertation(string title, string details, string autor, string dateProtection, string dateApproved, string amountPages)
        {
            if (String.IsNullOrEmpty(title)) throw new BibliographicExeption("Поле Title не должно быть пустым");
            if (String.IsNullOrEmpty(details)) throw new BibliographicExeption("Поле Details не должно быть пустым");
            if (String.IsNullOrEmpty(autor)) throw new BibliographicExeption("Поле Autor не должно быть пустым");
            if (String.IsNullOrEmpty(dateProtection)) throw new BibliographicExeption("Поле Date Protection не должно быть пустым");
            if (String.IsNullOrEmpty(dateApproved)) throw new BibliographicExeption("Поле Date Approved не должно быть пустым");
            if (String.IsNullOrEmpty(amountPages)) throw new BibliographicExeption("Поле Amount Pages не должно быть пустым");
            _title = title;
            _details = details;
            _autor = autor;
            _dateProtection = dateProtection;
            _dateApproved = dateApproved;
            _amountPages = amountPages;
            resString = _title + " : " + _details + " : " + _dateProtection + " : " + _dateApproved + " /" + _autor + ". – " + _amountPages + " с.";
        }
        public string Print
        {
            get { return resString; }
        }
    }
}
