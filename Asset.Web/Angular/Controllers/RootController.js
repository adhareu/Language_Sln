﻿assetApp.controller('rootController', function ($scope, $rootScope, $translate) {
    $rootScope.LanguageID = 2;
   
    $scope.init = function () {
       
        Encrypt.key = CryptoJS.enc.Utf8.parse("asdfghjklpoiuytr");
        Encrypt.iv = CryptoJS.enc.Utf8.parse("rtyuioplkjhgfdsa");
        $rootScope.setHeaders();
    }
   
    $rootScope.setHeaders = function () {
        this.headersWithLog = {
            "Access-Control-Allow-Origin": "*",
            "ApiKey": "abcd",
            "User": "1",
            "Log": true
        };
        this.headersWithoutLog = {
            "Access-Control-Allow-Origin": "*",
            "ApiKey": "abcd",
            "User": "1",
            "Log": false
        }


    }

    $translate.use("de");
   

    
   
    $scope.init();
});