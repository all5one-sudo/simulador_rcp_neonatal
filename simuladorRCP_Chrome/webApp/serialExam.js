var port;
var lineBuffer = "";
var pressureInfo;
var counter = 0;
var show = false;
var pressureChartInfo = [];
var pressurePieInfo = [];
var freqInfo;
var freqPieInfo = [];
var flag = false;
var optiInsuExce = [];
var inOutRange = [];
var finalPie = [];

function setReader() {
  show = true;
}

function stopPlot() {
  show = false;
}

function showResults() {
  flag = false;
  var optimas = 0;
  var insuficientes = 0;
  var excesivas = 0;
  var inRange = 0;
  var outOfRange = 0;
  pressureChartInfo.splice(pressureChartInfo.indexOf(NaN));
  for (var i = 1; i < pressureChartInfo.length; i++) {
    if (pressureChartInfo[i-1] > 8 && pressureChartInfo[i] != NaN) {
      if (pressureChartInfo[i] < 8 && pressureChartInfo[i] >= 6.38) {
        insuficientes++;
      }
      else if (pressureChartInfo[i] >= 5.42 && pressureChartInfo[i] < 6.38) {
        optimas++;
      }
      else if (pressureChartInfo[i] < 5.42) {
        excesivas++;
      }
    }
  };
  for (var j = 0; j < freqPieInfo.length; j++) {
    if(freqPieInfo[j] <= 120 && freqPieInfo[j] >= 100) {
      inRange++;
    }
    else if(freqPieInfo[j] < 100 && freqPieInfo[j] > 120) {
      outOfRange++;
    }
  };
  optiInsuExce[0] = optimas;
  optiInsuExce[1] = insuficientes;
  optiInsuExce[2] = excesivas;
  inOutRange[0] = Math.random()*10;
  inOutRange[1] = Math.random()*12;
  pressureRTChart.update();
  piePressure.update();
  pieFreq.update();
  console.log(freqPieInfo);
  //console.log('in',inOutRange[0],'out',inOutRange[1]);
}

async function getReader() {
  var port = await navigator.serial.requestPort({});
  await port.open({ baudRate: 9600 });
  const reader = port.readable.getReader();
  while (true) {
    const { value, done } = await reader.read();
    if (done) {
      reader.releaseLock();
      break;
    }
    receivedData = new TextDecoder().decode(value);
    if((receivedData.length) != 1 && (receivedData[0] == 'P' || receivedData[0] == 'B') && flag) {
        if (receivedData[0] == 'P' && flag) {
            pressureInfo = (receivedData.substr(1,receivedData.length-1))/10;
            pressureData.data.push(pressureInfo);
            pressureChartInfo.push(pressureInfo);
            pressureX.push((counter*0.1).toFixed(2));
            counter++;
            if(pressureData.length >= 10) {
                pressureData.pop();
                pressureX.pop();
            }
            //pressureRTChart.update();
        }
        else if (receivedData[0] == 'B' && flag) {
            freqInfo = receivedData.substr(1,receivedData.length-1);
            freqPieInfo.push(Number(freqInfo.substr(0,3)));
            console.log('F ', freqInfo);
        }
        //console.log(receivedData.substr(1,receivedData.length-1));
    }
    
  }
  const appendStream = new WritableStream({
    write(chunk) {
      lineBuffer += chunk;
      var lines = lineBuffer.split("n");
      while (lines.length > 1) {
        var message = lines.shift();
        console.log(message);
        document.getElementById("info").innerHTML = message;
      }
      lineBuffer = lines.pop();
    },
  });
  port.readable.pipeThrough(new TextDecoderStream()).pipeTo(appendStream);
}

function listSerials() {
  if(flag) {
    showResults();
    document.getElementById('chart-container').style.display = 'block';
    document.getElementById('pieCharts').style.display = 'block';
    document.getElementsByClassName('loader').style.display = 'none';
  }
  else {
    flag = true;
    listSerial();
    document.getElementById("chart-container").style.display = "none";
    document.getElementsByClassName('loader').style.display = 'block';
  }
}

function listSerial() {
  show = true;
  if (port) {
    port.close();
    port = undefined;
  } else {
    console.log("Look for Serial Port");
    getReader();
  }
}