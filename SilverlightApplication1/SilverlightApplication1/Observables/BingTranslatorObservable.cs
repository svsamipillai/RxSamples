﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;
using System.Collections.Generic;
using SilverlightApplication1.BingTranslatorService;

namespace SilverlightApplication1.Observables
{
    public static class BingTranslatorObservable
    {
        /// <summary>
        /// The AppId identifies your application at the Bing online service.
        /// Before running the application, you have to get your free AppId
        /// here: http://www.bing.com/developers/createapp.aspx
        /// </summary>
        const string AppID = "1848A7A37C632E32B67492E22DA29125992A298C";

        //public static IObservable<Object[]> TranslateAsync(this string text,
        //    string sourceLanguage, string targetLanguage)
        //{
        //    LanguageService svc = new BingTranslatorService.LanguageServiceClient();
        //    var values = new ServiceParams { AppID = AppID, sourceLanguage = sourceLanguage, targetLanguage = targetLanguage, Text = text };
            
        //    var obs = Observable.Using(() => new BingTranslatorService.LanguageServiceClient(),
        //        () => Observable.FromAsyncPattern<TranslateRequest, TranslateResponse>(svc.BeginTranslate, svc.EndTranslate)(values));
        //    return obs;
        //}
    }
}
