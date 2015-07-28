var phonecatApp = angular.module('phonecatApp', []);

phonecatApp.controller('PhoneListCtrl', function ($scope,$http) {    
    $http.get('/api/phone/').success(function (data, status, headers, config) {
        $scope.phones = data;
    })
});
