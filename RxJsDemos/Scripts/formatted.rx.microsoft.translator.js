﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// This code is licensed by Microsoft Corporation under the terms
// of the MICROSOFT REACTIVE EXTENSIONS FOR JAVASCRIPT AND .NET LIBRARIES License.
// See http://go.microsoft.com/fwlink/?LinkId=186234.

(function () {
    var a = jQuery;
    var b = a.fn;
    var c = this;
    var d;
    var e;
    if (!c.Microsoft) d = c.Microsoft = {};
    else d = c.Microsoft;
    var f = "http://api.microsofttranslator.com/V2/Ajax.svc/";
    var g = function (i) {
        return i.data;
    };
    var h = d.Translator = function (i) {
        this.addTranslation = function (j, k, l, m, n) {
            return a.ajaxAsObservable({
                url: f + "AddTranslation", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, originalText: j, translatedText: k, from: l, to: m, user: n.user, rating: n.rating, contentType: n.contentType, category: n.category, uri: n.uri
                }

            }).Select(g);
        };
        this.addTranslationArray = function (j, k, l, m) {
            var n = JSON.stringify(j);
            var o = JSON.stringify(m);
            return a.ajaxAsObservable({
                url: f + "AddTranslationArray", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, translations: n, from: k, to: l, options: o
                }

            }).Select(g);
        };
        this.breakSentences = function (j, k) {
            return a.ajaxAsObservable({
                url: f + "BreakSentences", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, text: j, language: k
                }

            }).Select(g);
        };
        this.detect = function (j) {
            return a.ajaxAsObservable({
                url: f + "Detect", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, text: j
                }

            }).Select(g);
        };
        this.detectArray = function (j) {
            var k = JSON.stringify(j);
            return a.ajaxAsObservable({
                url: f + "DetectArray", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, texts: k
                }

            }).Select(g);
        };
        this.getLanguageNames = function (j, k) {
            var l = JSON.stringify(k);
            return a.ajaxAsObservable({
                url: f + "GetLanguageNames", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, locale: j, languageCodes: l
                }

            }).Select(g);
        };
        this.getLanguagesForSpeak = function () {
            return a.ajaxAsObservable({
                url: f + "GetLanguagesForSpeak", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i
                }

            }).Select(g);
        };
        this.getLanguagesForTranslate = function () {
            return a.ajaxAsObservable({
                url: f + "GetLanguagesForTranslate", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i
                }

            }).Select(g);
        };
        this.getTranslations = function (j, k, l, m, n) {
            var o = JSON.stringify(n);
            return a.ajaxAsObservable({
                url: f + "GetTranslations", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, text: j, from: k, to: l, maxTranslations: m, options: o
                }

            }).Select(g);
        };
        this.getTranslationsArray = function (j, k, l, m, n) {
            var o = JSON.stringify(j);
            var p = JSON.stringify(n);
            return a.ajaxAsObservable({
                url: f + "GetTranslationsArray", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, texts: o, from: k, to: l, maxTranslations: m, options: p
                }

            }).Select(g);
        };
        this.speak = function (j, k, l) {
            if (l == null) l = "audio/wav";
            return a.ajaxAsObservable({
                url: f + "Speak", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, text: j, language: k, format: l
                }

            }).Select(g);
        };
        this.translate = function (j, k, l) {
            return a.ajaxAsObservable({
                url: f + "Translate", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, text: j, from: k, to: l
                }

            }).Select(g);
        };
        this.translateArray = function (j, k, l, m) {
            var n = JSON.stringify(j);
            var o = JSON.stringify(m);
            return a.ajaxAsObservable({
                url: f + "TranslateArray", dataType: "jsonp", jsonp: "oncomplete", data: {
                    appId: i, texts: n, from: k, to: l, options: o
                }

            }).Select(g);
        };
    };
    d.Translator.getAppIdToken = function (i, j, k, l) {
        return a.ajaxAsObservable({
            url: f + "GetAppIdToken", dataType: "jsonp", jsonp: "oncomplete", data: {
                appId: i, minRatingRead: j, maxRatingRead: k, expireSeconds: l
            }

        }).Select(g);
    };
})();
