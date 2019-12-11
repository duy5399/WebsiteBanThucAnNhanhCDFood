var i = 2;
var temp = 0;
function switch_img() {
    document.images['SUSHI'].src = '/Images/doanNhatBan/sushi' + i + '.jpg';
    document.images['TAKOYAKI'].src = '/Images/doanNhatBan/takoyaki' + i + '.jpg';
    document.images['GIMBAB'].src = '/Images/doanHanQuoc/gimbab' + i + '.jpg';
    document.images['JAJANGMYEON'].src = '/Images/doanHanQuoc/jajangmyeon' + i + '.jpg';
    document.images['SMOOTHIES'].src = '/Images/thucuong/smoothies' + i + '.jpg';
    document.images['MILK TEA'].src = '/Images/thucuong/milk_tea' + i + '.jpg';
    document.images['SUNDUBU-JJIGAE'].src = '/Images/doanHanQuoc/sundubu-jjigae' + i + '.jpg';
    document.images['UNAGI'].src = '/Images/doanNhatBan/unagi' + i + '.jpg';
    document.images['LATTE'].src = '/Images/thucuong/latte' + i + '.jpg';
    if (i == 2)
        i = 1;
    //temp++;
    //switch (temp) {
    //    case 1:
    //        document.images['SUSHI'].src = '/Images/doanNhatBan/sushi' + i + '.jpg';
    //        document.images['TAKOYAKI'].src = '/Images/doanNhatBan/takoyaki' + i + '.jpg';
    //        document.images['GIMBAB'].src = '/Images/doanHanQuoc/gimbab' + i + '.jpg';
    //        document.images['JAJANGMYEON'].src = '/Images/doanHanQuoc/jajangmyeon' + i + '.jpg';
    //        document.images['SMOOTHIES'].src = '/Images/thucuong/smoothies' + i + '.jpg';
    //        document.images['MILK TEA'].src = '/Images/thucuong/milk_tea' + i + '.jpg';
    //        document.images['SUNDUBU-JJIGAE'].src = '/Images/doanHanQuoc/sundubu-jjigae' + i + '.jpg';
    //        document.images['UNAGI'].src = '/Images/doanNhatBan/unagi' + i + '.jpg';
    //        document.images['LATTE'].src = '/Images/thucuong/latte' + i + '.jpg';
    //        break;
    //    case 2:
    //        document.images['SHASIMI'].src = '/Images/doanNhatBan/sashimi' + i + '.jpg';
    //        document.images['RAMEN'].src = '/Images/doanNhatBan/ramen' + i + '.jpg';
    //        document.images['TOKBOKKI'].src = '/Images/doanHanQuoc/tokbokki' + i + '.jpg';
    //        document.images['KIMCHI'].src = '/Images/doanHanQuoc/kimchi' + i + '.jpg';
    //        document.images['FRUIT TEA'].src = '/Images/thucuong/fruit_tea' + i + '.jpg';
    //        document.images['COFFEE'].src = '/Images/thucuong/coffee' + i + '.jpg';
    //        document.images['BIBIMBAP'].src = '/Images/doanHanQuoc/bibimbap' + i + '.jpg';
    //        document.images['SODA MOJITO'].src = '/Images/thucuong/soda_mojito' + i + '.jpg';
    //        document.images['TONKATSU'].src = '/Images/doanNhatBan/tonkatsu' + i + '.jpg';
    //        break;
    //    case 3:
    //        document.images['BULGOGI'].src = '/Images/doanHanQuoc/bulgogi' + i + '.jpg';
    //        document.images['KAISEKI RYORI'].src = '/Images/doanNhatBan/kaiseki_ryori' + i + '.jpg';
    //        document.images['AURORA SERIES'].src = '/Images/thucuong/thealley' + i + '.jpg';
    //        document.images['SEOLLEONGTANG'].src = '/Images/doanHanQuoc/seolleongtang' + i + '.jpg';
    //        document.images['YAKITORI'].src = '/Images/doanNhatBan/yakitori' + i + '.jpg';
    //        document.images['WINE'].src = '/Images/thucuong/ruou-vang' + i + '.jpg';
    //}
    //if (temp >= 3 && i == 1) {
    //    temp = 0;
    //    i = 2;
    //}
    //else if (temp >= 3 && i == 2) {
    //    temp = 0;
    //    i = 1;
    //}
    setTimeout(switch_img, 3000);
}