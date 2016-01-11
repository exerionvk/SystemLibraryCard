using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibraryCard
{
    public class Magazine : IBibliographicDescription
    {
        private string _title;
        private string _details;
        private string _founder;
        private string _issueNumber;
        private string _amountPages;
        public string resString;
        public Magazine(string title, string details, string founder, string issueNumber, string amountPages)
        {
            if (String.IsNullOrEmpty(title)) throw new BibliographicExeption("Поле Title не должно быть пустым");
            if (String.IsNullOrEmpty(details)) throw new BibliographicExeption("Поле Details не должно быть пустым");
            if (String.IsNullOrEmpty(founder)) throw new BibliographicExeption("Поле Founder не должно быть пустым");
            if (String.IsNullOrEmpty(issueNumber)) throw new BibliographicExeption("Поле Issue number не должно быть пустым");
            if (String.IsNullOrEmpty(amountPages)) throw new BibliographicExeption("Поле Amount Pages не должно быть пустым");
            _title = title;
            _details = details;
            _founder = founder;
            _issueNumber = issueNumber;
            _amountPages = amountPages;
            resString = _title + " – " + _details + " // " + _founder + ". –№" + _issueNumber + ". – С. " + _amountPages;
        }
        public string Print
        {
            get { return resString; }
        }
    }
}
