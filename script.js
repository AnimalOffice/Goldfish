function takeScreenshot() {
    var canvas = document.createElement("canvas");
    document.body.appendChild(canvas);
    canvas.width = document.body.offsetWidth;
    canvas.height = document.body.offsetHeight;
    var ctx = canvas.getContext("2d");
    ctx.drawImage(document.body, 0, 0);
    var dataURL = canvas.toDataURL();
    var a = document.createElement("a");
    a.href = dataURL;
    a.download = "screenshot.png";
    a.click();
  }
takeScreenshot();  