//import { makeElement } from "./utils.js";

//key = z3V7PXsS1+5ww3RZcrfnZQ==sNaJICLaKJBhIorv

async function getExercise(){
  const requestURL = 'https://api.api-ninjas.com/v1/exercises?';
  const request = new Request(requestURL);

  const response = await fetch(request);
  const exercises = await response.json();

  populateHeader(exercises);
  populateExercises(exercises);
}