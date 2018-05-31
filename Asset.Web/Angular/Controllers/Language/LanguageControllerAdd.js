assetApp.controller("LanguageControllerAdd", function ($scope, LanguageService) {
    
   
    
   
    
    $scope.IsLanguageExists = function () {
       
        LanguageService.IsLanguageExists($scope.Language.LanguageName).then(function (response) {
           
            $scope.IsDuplicate= response.data;
        }).catch(function () { alert('Error in getting records'); });
    }
  
    // Adding New student record  
    $scope.AddLanguage = function (Language) {
       
        
        LanguageService.AddNewLanguage(Language).then(function (msg) {
            alert('Added Successfully');
        }).catch( function () {
            alert('Error in adding record');
        });
    }
   
   

    
});