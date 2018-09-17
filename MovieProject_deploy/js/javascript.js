window.onload = function () {
        var chart = new CanvasJS.Chart("Report", {
            animationEnabled: true,

            title: {
                text: "REPORT"
            },
            axisX: {
                interval: 1
            },
            axisY2: {
                interlacedColor: "#EEE0B1",
                gridColor: "rgba(0,255,255,.3)"
            },
            data: [{
                type: "bar",
                name: "movie",
                axisYType: "secondary",
                color: "#A1CAF1",
                dataPoints: [
                    { y: 2, label: "" },
                    { y: 2, label: "Animation" },
                    { y: 2, label: "Comedy" },
                    { y: 1, label: "Crime" },
                    { y: 6, label: "Drama" },
                    { y: 2, label: "Mysteri" },
                    { y: 7, label: "Sci-Fe" },
                    { y: 6, label: "Thriller" }
                ]
            }]
        });
        chart.render();
    }


