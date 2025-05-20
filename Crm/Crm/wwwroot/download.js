window.downloadFile = (fileName, dataUrl) => {
    var link = document.createElement('a');
    link.href = dataUrl;
    link.download = fileName;
    link.click();
};

