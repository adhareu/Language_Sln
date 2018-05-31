assetApp.controller("LanguageControllerEdit", function ($scope, $location, LanguageService) {

    $scope.Language = {};
    //Get Student INformation By Id

    var Id = $location.search()["id"];
    LanguageService.getLanguage(Id).then(function (response) {

        $scope.Language = response.data;
    }).catch(function () { alert('Error in getting records'); });


    $scope.IsLanguageExistsWithID = function () {

        LanguageService.IsLanguageExistsWithID(Id, $scope.Language.LanguageName).then(function (response) {

            $scope.IsDuplicate = response.data;
        }).catch(function () { alert('Error in getting records'); });
    }
    // Updateing Records  
    $scope.UpdateLanguage = function (tbl_Language) {
      
        var RetValData = LanguageService.UpdateLanguage(tbl_Language);
        RetValData.then(function (msg) {
            
                alert('Updated Successfully');


        }).catch(function () {
            alert('Error in getting records');
        });
    }


});