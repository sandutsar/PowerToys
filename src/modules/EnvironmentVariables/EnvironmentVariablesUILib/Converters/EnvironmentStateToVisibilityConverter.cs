﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using EnvironmentVariablesUILib.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace EnvironmentVariablesUILib.Converters;

public class EnvironmentStateToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var type = (EnvironmentState)value;
        return type switch
        {
            EnvironmentState.Unchanged => Visibility.Collapsed,
            _ => Visibility.Visible,
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
