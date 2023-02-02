﻿namespace ClientWPF.Contracts.Views;

public interface INavigationAware
{
    void OnNavigatedTo(object parameter);

    void OnNavigatedFrom();
}
