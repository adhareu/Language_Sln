assetApp.service("LanguageService", ['$http', '$rootScope', function ($http, $rootScope) {
   
    this.headers = $rootScope.headersWithLog;
    this.noLogHeaders = $rootScope.headersWithoutLog;
    //get All Language  
    this.getAllLanguages = function () {
        debugger
        return $http({
            method: 'GET',
            url: api + "Language/GetAllLanguage",
          
            headers: this.noLogHeaders
        });
      
    };
    this.getLanguage = function (Id) {
        return $http({
            method: 'GET',
            url: api + 'Language/GetLanguage',
            params: {
                Id: Encrypt.encrypt(Id)
            },
            headers: this.noLogHeaders
        });
    };
    // Adding Record  
    this.AddNewLanguage = function (tbl_Language) {
        return $http({
            method: "post",
            url: api + "Language/AddLanguage",
            data: JSON.stringify(tbl_Language),
            headers: this.noLogHeaders,
            dataType: "json"
        });
    }
    // Updating record  
    this.UpdateLanguage = function (tbl_Language) {
        return $http({
            method: "PUT",
            url: api + "Language/UpdateLanguage",
            data: JSON.stringify(tbl_Language),
            headers: this.noLogHeaders,
            dataType: "json"
        });
    }
    // Deleting records  
    this.deleteLanguage = function (Id) {
        return $http({
            method: "PUT",
            url: api + "Language/DeleteLanguage",
            params: {
                Id: Encrypt.encrypt(Id)
            },
            headers: this.noLogHeaders,
            dataType: "json"
        });
       
    }
    this.IsLanguageExists = function (name) {
       
        return $http({
            method: "GET",
            url: api + "Language/IsLanguageExists",
            params: {
                Name: Encrypt.encrypt(name)
            },
            headers: this.noLogHeaders,
            dataType: "json"
        });
       
    };
    this.IsLanguageExistsWithID = function (id,name) {

        return $http({
            method: "GET",
            url: api + "Language/IsLanguageExistsWithID",
            params: {
                id: Encrypt.encrypt(id),
                Name: Encrypt.encrypt(name)
            },
            headers: this.noLogHeaders,
            dataType: "json"
        });

    };
}]);