app.controller('bienvenidoController', function ($scope, $http) {
    $scope.id = '';
    $scope.sendID = '';

    $scope.sendData = function () {


        $http.get('Pedido/Details/'+$scope.sendID)
            .then(function (data) {
                console.log(data);
                $scope.id = data.data;
            })
    }


});