const $pressureChart = document.querySelector("#pressureChart");
// Las pressureX son las que van en el eje X. 
const pressureX = []
// Podemos tener varios conjuntos de datos. Comencemos con uno
const pressureData = {
    label: "Desplazamiento del pecho [cm]",
    data: [],
    backgroundColor: 'rgba(54, 162, 235, 0.2)', 
    borderColor: 'rgba(54, 162, 235, 1)', 
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

