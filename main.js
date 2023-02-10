$(function () {

    newList = [
        { num: 0, img: "./poto/language/language_1-1.png", title: "精準7000單字滿分版", money: "定價$450", hot_money: "優惠價$360", class: "language", class2: "hot", publishing: "出版社:凱信企管顧問", author: "作者:Michael Yang;Tong Weng", publication_date: "出版日:2022/09/28", data_name: "language-1" },
        { num: 1, img: "./poto/language/language_2-1.png", title: "英文自我介紹看完這本就能說!", money: "定價$420", hot_money: null, class: "language", class2: null, publishing: "出版社:語研學院出版社", author: "作者:朴龍浩", publication_date: "出版日:2022/09/07", data_name: "language-2" },
        { num: 2, img: "./poto/language/language_3-1.png", title: "元氣日語初級", money: "定價$400", class: "language", class2: null, publishing: "出版社:瑞蘭國際", author: "作者:本間岐理;郭建甫", publication_date: "出版日:2022/09/21", data_name: "language-3" },
        { num: 3, img: "./poto/language/language_4-1.png", title: "生活必備日文單字", money: "定價$410", class: "language", class2: null, publishing: "出版社:不求人文化", author: "作者:清水裕美子", publication_date: "出版日:2022/03/30", data_name: "language-4" },
        { num: 4, img: "./poto/love/love-1-1.png", title: "你在左邊 放了一句再見", money: "定價$430", class: "love", class2: null, publishing: "出版社:三采文化", author: "作者:肆一", publication_date: "出版日:2020/08/03", data_name: "love-1" },
        { num: 5, img: "./poto/love/love-2-1.png", title: "我的口是心非 都是有邏輯的", money: "定價$470", hot_money: "優惠價$376", class: "love", class2: "hot", publishing: "出版社:任性出版", author: "作者:楊喵喵", publication_date: "出版日:2020/07/30", data_name: "love-2" },
        { num: 6, img: "./poto/love/love-3-1.png", title: "SKimmy的台北戀愛圖鑑", money: "定價$380", class: "love", class2: null, publishing: "出版社:平裝本", author: "作者:Skimmy", publication_date: "出版日:2020/07/06", data_name: "love-3" },
        { num: 7, img: "./poto/love/love-4-1.png", title: "渣男動物園", money: "定價$415", class: "love", class2: null, publishing: "出版社:時報文化", author: "作者:凱薩琳‧孔", publication_date: "出版日:2020/07/15", data_name: "love-4" },
        { num: 8, img: "./poto/literature/literatrue_1-1.png", title: "不便利的便利店", money: "定價$410", class: "literatrue", class2: null, publishing: "出版社:寂寞", author: "作者:金浩然", publication_date: "出版日:2022/09/01", data_name: "literatrue-1" },
        { num: 9, img: "./poto/literature/literatrue_2-1.png", title: "灰色人類", money: "定價$420", class: "literatrue", class2: null, publishing: "出版社:小異", author: "作者:金東植", publication_date: "出版日:2022/07/27", data_name: "literatrue-2" },
        { num: 10, img: "./poto/literature/literatrue_3-1.png", title: "候鳥的女兒", money: "定價$400", hot_money: "優惠價$320", class: "literatrue", class2: "hot", publishing: "出版社:臉譜文化", author: "作者:夏洛特‧麥康納吉", publication_date: "出版日:2022/05/14", data_name: "literatrue-3" },
        { num: 11, img: "./poto/literature/literatrue_4-1.png", title: "我的秘密河流", money: "定價$420", class: "literatrue", class2: null, publishing: "出版社:木馬文化", author: "作者:Kate Grenville", publication_date: "出版日:2022/04/13", data_name: "literatrue-4" },
        { num: 12, img: "./poto/travel/travel_1-1.png", title: "搭便車不是一件隨意的事", money: "定價$390", hot_money: "優惠價$312", class: "travel", class2: "hot", publishing: "出版社:聯經出版公司 ", author: "作者:李易安", publication_date: "出版日:2021/08/05", data_name: "travel-1" },
        { num: 13, img: "./poto/travel/travel_2-1.png", title: "好動旅程", money: "定價$380", class: "travel", class2: null, publishing: "出版社:萬里機構 ", author: "作者:何海濤", publication_date: "出版日:2019/10/10", data_name: "travel-2" },
        { num: 14, img: "./poto/food/food_1-1.png", title: "拉麵之魂", money: "定價$390", class: "food", class2: null, publishing: "出版社:墨刻", author: "作者:青木健", publication_date: "出版日:2022/09/08", data_name: "food-1" },
        { num: 15, img: "./poto/food/food_2-1.png", title: "心靈療癒的3D果凍花", money: "定價$400", hot_money: "優惠價$320", class: "food", class2: "hot", publishing: "出版社:上優文化", author: "作者:卞柔勻", publication_date: "出版日:2022/09/06", data_name: "food-2" },
        { num: 16, img: "./poto/food/food_3-1.png", title: "法式料理全技術", money: "定價$410", class: "food", class2: null, publishing: "出版社:台灣東販", author: "作者:荻野伸也", publication_date: "出版日:2021/08/06", data_name: "food-3" },
        { num: 17, img: "./poto/food/food_4-1.png", title: "咖啡學堂", money: "定價$430", class: "food", class2: null, publishing: "出版社:晨星", author: "作者:王稚雅", publication_date: "出版日:2022/05/01", data_name: "food-4" },
        { num: 18, img: "./poto/finance/finance_1-1.png", title: "通膨的恐懼", money: "定價$480", class: "finance", class2: null, publishing: "出版社:樂金文化", author: "作者:羅伯特．霍克特, 亞倫．詹姆斯", publication_date: "出版日:2022/09/07", data_name: "finance-1" },
        { num: 19, img: "./poto/finance/finance_2-1.png", title: "圖解x總體經濟學", money: "定價$440", hot_money: "優惠價$352", class: "finance", class2: "hot", publishing: "出版社:十力文化", author: "作者:菅原晃", publication_date: "出版日:2022/07/14", data_name: "finance-2" },
        { num: 20, img: "./poto/finance/finance_3-1.png", title: "PARTS談判思維", money: "定價$460", class: "finance", class2: null, publishing: "出版社:商周出版", author: "作者:林宜璟", publication_date: "出版日:2022/09/10", data_name: "finance-3" }

    ]
    // ------右邊顯示的圖片及字元素------
    // console.log(newList)
    $.each(newList, function (key, obj) {
        var img = obj.img;
        var title = obj.title;
        var myclass = obj.class;
        var myclass2 = '';
        var myclass3 = obj.calss3;
        var title2 = obj.title2;
        var myMoney = obj.money;
        var myhotMoney = '';
        var myDiscount = '';
        var mypublishing = obj.publishing;
        var myauthor = obj.author;
        var mypublication_date = obj.publication_date;
        var data_Name = obj.data_name;
        var Num = obj.num

        if (obj.hot_money != null) {
            myhotMoney = `<i>${obj.hot_money}</i>`;
            myMoney = `<s>${obj.money}</s>`;
        }
        if (obj.class2 != null) {
            myclass2 = obj.class2;
        }
        if (obj.Discount != null) {
            myDiscount = `<span>${obj.Discount}</span>`
        }

        var $mytag = `<div class="${myclass} ${myclass2} " data-name="${data_Name}">
            <img src="${img}" data-name="${data_Name}">
            <p>${title}</p>
            <p>${myMoney} ${myhotMoney}</p>
            ${myDiscount}
            </div>`;

        $("#form").append($mytag);

        var $mypord = `<div class="${myclass} ${myclass2} ${data_Name}" data-name="${data_Name}">
            <img src="${img}" data-name="${data_Name}">
            <div class="${myclass} ${myclass2} ${data_Name}" data-name="${data_Name}"><h3>${title}</h3>
            <ul>
                <li>${myauthor}</li>
                <li>${mypublishing}</li>
                <li>${mypublication_date}</li>
                <li>${myMoney} ${myhotMoney}</li>
                </ul>
                </div>
                <div class="${data_Name} bbt" data-bss="${Num}"><button onclick="return false">加入購物車</button></div>
                </div>`;

        $("#product_form").append($mypord);

        // ----------購物車---------

        // console.log(newList[0]);

    })
    // ------------產品亂數顯示-----------
    $(`.form div`).hide();
    var Str = '';
    var ax = [];
    for (var i = 0; i < 6; i++) {
        var Str = Math.floor(Math.random() * newList.length);
        console.log(Str);
        if (ax.indexOf(Str) == -1) {
            ax.push(Str);
        } else {
            i--;
        }
        $(`.form div`).eq(Str).show();

    }

    // ---------左邊標籤觸發顯示隱藏右邊網頁---------

    $(".tag").on("click", function () {
        // console.log();
        var inInd = $(this).data("book");
        // console.log(inInd); // love

        // var iss = $(`.${inInd}`);
        // console.log(iss);

        $(`.form div`).hide();
        $(`.product_form`).hide();
        $(`.${inInd}`).show();

    })


    $("form img").on("click", function () {
        var prod = $(this).data("name");
        // console.log(prod);

        $(`.form div`).hide();
        $(`.product_form`).show();
        $(`.product_form div`).hide();
        $(`.product_form .${prod}`).show();
    })


    // ---------購物車-------------
    // console.log(newList[0])
    // var ppp = newList[0].title;
    // $("#lis-1").append(ppp);

    $(".bbt").on("click", function () {
        alert("此刻維護中，請稍後再進入")
        // var shop = $(this).data("bss");
        // var pp = newList[shop].title;
        // console.log(pp);
        // $(product_form).submit();


        // $("#lis-1").append(pp);



        // var sa = newList[shop].img;
        // var sf = newList[shop].money;
        // console.log(sa);
        // console.log(sf);


    })
    $(".shopping").on("click", function () {
        alert("此刻維護中，請稍後再進入")
    })




    // console.log(pp);
})



