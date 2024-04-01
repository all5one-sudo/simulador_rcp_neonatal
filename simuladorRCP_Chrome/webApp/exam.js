const $pressureChart = document.querySelector("#pressureChart");
const $piePressureChart = document.querySelector("#piePressureChart");
const $pieFreqChart = document.querySelector("#pieFreqChart");
const pressureX = []
let colorHexPressure = ['#38A3A5','#57CC99','#80ED99'];
let colorHexFreq = ['#F49390','#F45866','#06BEE1'];

const pressureData = {
    label: "Desplazamiento del pecho [cm]",
    data: [],
    backgroundColor: 'rgba(0,136,169,1)', 
    borderColor: 'rgba(0,136,169, 0.8)', 
    borderWidth: 3,
    fill: false
};

var piePressure = new Chart($piePressureChart, {
    type: 'pie',
    data: {
        datasets: [{
            data: optiInsuExce,
            backgroundColor: colorHexPressure
        }],
        labels: ['Compresiones óptimas', 'Compresiones leves', 'Compresiones excesivas']
    },
    options:{
        responsive: true,
        title: {
            display: true,
            position: "top",
            text: "Resultados del examen de compresiones",
            fontSize: 14,
            fontColor: "#F2FDFF",
            FontFace: 'Montserrat'
          },
          legend: {
            labels: {
                fontColor: "#F2FDFF"
            }
          }
    }
});

var pieFreq = new Chart($pieFreqChart, {
    type: 'pie',
    data: {
        datasets: [{
            data: inOutRange,
            backgroundColor: colorHexFreq
        }],
        labels: ['Dentro del rango óptimo', 'Fuera del rango óptimo']
    },
    options:{
        responsive: true,
        title: {
            display: true,
            position: "top",
            text: "Resultados del examen de BPM",
            fontSize: 14,
            fontColor: "#F2FDFF",
            FontFace: 'Montserrat'
          },
          legend: {
            labels: {
                fontColor: "#F2FDFF"
            }
          }
    }
});

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
            display: true,
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

