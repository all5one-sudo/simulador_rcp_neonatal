var port;
var lineBuffer = "";
var pressureInfo;
var freqInfo;
var counter = 0;
var show = false;

function setReader() {
  show = true;
}

function stopPlot() {
  show = false;
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
    if((receivedData.length) != 1 && (receivedData[0] == 'P' || receivedData[0] == 'B')) {
        if (receivedData[0] == 'P' && show) {
            pressureInfo = (receivedData.substr(1,receivedData.length-1))/10;
            pressureData.data.push(pressureInfo);
            pressureX.push((counter*0.1).toFixed(2));
            counter++;
            if(pressureData.length >= 10) {
                pressureData.pop();
                pressureX.pop();
            }
            pressureRTChart.update();
        }
        else if (receivedData[0] == 'B' && show) {
            freqInfo = receivedData.substr(1,receivedData.length-1);
            document.getElementById('bpm').innerHTML = freqInfo;
        }
        console.log(receivedData.substr(1,receivedData.length-1));
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