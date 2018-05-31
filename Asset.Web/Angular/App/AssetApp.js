var api = "http://localhost:7764/api/";



var translationsEN = {
  Name: 'Name',
  Save: 'Save',
  Update: 'Update',
    Edit:'Edit',
  Department: 'Department',
  DepartmentList: 'Department List',
  AddDepartment: 'Add Department',
  DepartmentCreate: 'Department Create',
  DepartmentUpdate:'Department Update'
};
 
var translationsDE= {
    Name: 'Name',
    Save: 'speichern',
    Update: 'Aktualisieren',
    Edit: 'redigieren',
    Department: 'Abteilung',
    DepartmentList: 'Abteilungsliste',
    AddDepartment: 'Abteilung hinzufügen',
    DepartmentCreate: 'Abteilung erstellen',
    DepartmentUpdate: 'Abteilungsupdate'
    
};


var assetApp = angular.module("assetApp", ['ngMessages', 'datatables','pascalprecht.translate']);


assetApp.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
}]);

assetApp.config(['$translateProvider', function ($translateProvider) {
    // add translation tables
    $translateProvider.translations('en', translationsEN);
    $translateProvider.translations('de', translationsDE);
    $translateProvider.fallbackLanguage('en');
    $translateProvider.preferredLanguage('en');
}]);


