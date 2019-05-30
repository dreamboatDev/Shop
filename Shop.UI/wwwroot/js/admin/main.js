var app = new Vue({
    el: '#app',
    data: {
        price: 0,
        showPrice: true
    },
    methods: {
        tooglePrice: function () {
            this.showPrice = !this.showPrice;
        },
        alert(x) {
            alert(x);
        }
    },
    computed: {
        formatPrice: function () {
            return "₴" + this.price;
        }
    }
});


