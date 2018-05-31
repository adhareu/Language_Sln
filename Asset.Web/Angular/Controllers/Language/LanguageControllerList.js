
assetApp.controller("LanguageControllerList", function ($scope,$rootScope,$translate, LanguageService, DTOptionsBuilder) {
    
    $scope.Language = {};
    $scope.Languages = [];
  

   
    
    //To Get All Records  
  
       
    LanguageService.getAllLanguages().then(function (Language) {
        $scope.Languages = Language.data;
    }).catch(function () {
        alert('Error in getting records');
    });
    
   
   
    
   
    // Deleting record.  
    $scope.deleteLanguage = function (Language, index) {
        var retval = LanguageService.deleteLanguage(Language.StudentId).then(function (msg) {
            
        }).catch(function () {
            alert('Oops! something went wrong.');
        });
    }
    $scope.changeLanguage = function (languageId) {
        debugger

        LanguageService.getLanguage(languageId).then(function (response) {
            debugger
            $scope.Language = response.data;

            $rootScope.LanguageID = $scope.Language.LanguageID

            $translate.use($scope.Language.LanguageName);

        }).catch(function () { alert('Error in getting records'); });
        
       
    };

    $scope.dtOptions = DTOptionsBuilder.newOptions()
                .withPaginationType('full_numbers')
                .withDisplayLength(2);
});
