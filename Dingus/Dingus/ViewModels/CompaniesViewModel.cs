﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Dingus.Models;
using Dingus.Services;

namespace Dingus.ViewModels
{
    class CompaniesViewModel : ViewModelBase
    {
        private string _search;
        private Company _company;
        private ObservableCollection<Company> _companies;

        public ICommand TextChangeCommand { get; private set; }
        public ICommand SelectedCompanyCommand { get; private set; }

        private CompanyServices CompanyService { get; set; }

        public CompaniesViewModel()
        {
            CompanyService = new CompanyServices();
            TextChangeCommand = new Command(TextChangeCommandHandler);
            SelectedCompanyCommand = new Command<Company>(SelectedCompanyCommandHandler);            
        }

        private void TextChangeCommandHandler()
        {
            if(string.IsNullOrWhiteSpace(Search) == true)
            {
                return;
            }

            try
            {
                SelectedCompany = null;
                Companies = new ObservableCollection<Company>(CompanyService.GetCompanies(Search));
            }
            catch
            {
                return;
            }
        }

        private async void SelectedCompanyCommandHandler(Company companySymbol)
        {
            SelectedCompany = companySymbol;
            SelectedCompany.Quote = await CompanyService.GetCompanyQuote(SelectedCompany.Symbol);
            SelectedCompany.Charts = await CompanyService.GetCompanyChart(SelectedCompany.Symbol);
        }

        public ObservableCollection<Company> Companies
        {
            get { return _companies; }
            set { SetProperty(ref _companies, value); }
        }

        public string Search
        {
            get { return _search; }
            set { SetProperty(ref _search, value); }
        }

        public Company SelectedCompany
        {
            get { return _company; }
            set { SetProperty(ref _company, value); }
        }
    }
}
