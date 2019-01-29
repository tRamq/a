var sayac = 0;
var app = angular
    .module("haberlerModul", [])
    .controller("haberlerController", function ($scope) {

        var haberler = [
            { haberAdi: "ABD'deki saldırıyla ilgili FBI'dan flaş açıklama!", icerik: "Las Vegas'ta konsere yapılan saldırıda ölenlerin sayısı 58'e yükselirken, saldırganın DEAŞ'la bağlantısının olmadığı açıkladı.", tarih:"12/10/2018" },
            { haberAdi: "ABD'den vize kriziyle ilgili son dakika açıklaması", icerik: "Büyükelçiliğimizin dünkü açıklamasında, göçmen olmayan vize hizmetlerini askıya aldığımızı dile getirdik. Söz konusu askıya alma, Türkiye Cumhuriyeti Hükümeti'nin ABD Misyonu tesisleri ve personelinin güvenliğine ilişkin taahhütlerini değerlendirirken, Büyükelçilik ve Konsolosluklarımıza gelen ziyaretçi sayısını en aza indirmemize olanak sağlamaktadır.", tarih:"15/10/2018" },
            { haberAdi: "ABD'li generalden Trump ile ilgili nükleer çıkış", icerik: "ABD Stratejik Kuvvetler (STRATCOM) Komutanı Orgeneral John Hyten, Trump’ın yasal olmayan bir şekilde nükleer silah kullanmak istemesi durumunda Trump’a karşı çıkacağını söyledi", tarih: "30/09/2018"}
        ];

        $scope.haberler = haberler;
        $scope.sutunSirala = "haberAdi";
        $scope.cevir = false;

        $scope.veriSirala = function (sutun) {
            $scope.cevir = ($scope.sutunSirala == sutun) ? !$scope.cevir : false;
            $scope.sutunSirala = sutun;
        }
        $scope.siralaClass = function (sutun) {

            if ($scope.sutunSirala == sutun) {
                return $scope.cevir ? 'azalan' : 'artan';
            }
            return '';
        }
    });