// http-post.js

document.addEventListener("DOMContentLoaded", function () {
  const httpPostButton = document.getElementById("http-post-button");
  const httpPostResult = document.getElementById("http-post-result");

  httpPostButton.addEventListener("click", function () {
    // Define the data you want to send in the POST request
    const postData = {
      name: "Joshua",
      program: "all", // Change to "cs," "se," or "me" as needed
    };

    // Convert the data to JSON format
    const jsonPostData = JSON.stringify(postData);

    // Set up the HTTP request
    const xhr = new XMLHttpRequest();
    xhr.open("POST", "http://35.188.215.226:8000/my_program");
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onload = function () {
      if (xhr.status === 200) {
        // Request was successful; display the response
        const response = JSON.parse(xhr.responseText);
        httpPostResult.textContent = JSON.stringify(response, null, 2);
      } else {
        // Request failed; display an error message
        httpPostResult.textContent = "HTTP POST Request Failed";
      }
    };

    xhr.send(jsonPostData);
  });
});
