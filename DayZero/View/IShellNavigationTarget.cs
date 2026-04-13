// <copyright file="ITableData.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.View
{

    public interface IShellNavigationTarget
    {
        ObservableViewModel? ViewModel
        {
            get; set;
        }
    }


}
