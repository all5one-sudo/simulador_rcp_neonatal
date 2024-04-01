const $pressureChart = document.querySelector("#pressureChart");
const pressureX = []
const pressureData = {
    label: "Desplazamiento del pecho [cm]",
    data: [],
    backgroundColor: 'rgba(0,136,169,1)', 
    borderColor: 'rgba(0,136,169, 0.8)', 
    borderWidth: 3,
    fill: false
};
var pressureRTChart = new Chart($pressureChart, {
    type: 'line',
    data: {
        labels: pressureX,
        datasets: [
            pressureData,
        ]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        scales: {
            x: [{
                display: true,
                title: {
                    display: true,
                    text: 'Tiempo [seg]'
                },
            }],
            y: {
                display: true,
                title: {
                    display: true,
                    text: 'Recorrido [cm]'
                },
            },
            yAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'Recorrido [cm]',
                    color: "#F2FDFF",
                    fontColor: "#F2FDFF"
                },
                ticks: {
                    beginAtZero: false,
                    color: "#F2FDFF",
                    fontColor: "#F2FDFF"
                },
            }],
            xAxes : [{
                scaleLabel: {
                    display: true,
                    labelString: 'Tiempo [seg]',
                    fontColor: "#F2FDFF"
                },
                ticks: {
                    color: "#F2FDFF",
                    fontColor: "#F2FDFF"
                },
            }],
        },
        title: {
            display: false,
            position: "top",
            text: "Evolución temporal de la prueba realizada",
            fontSize: 14,
            fontColor: "#F2FDFF",
            FontFace: 'Montserrat'
          },
        legend: {
            display: false
        },
        elements: {
            point:{
                radius: 0
            }
        }
    },
});

