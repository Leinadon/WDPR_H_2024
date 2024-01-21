import React from 'react';

import { render, fireEvent, waitFor } from '@testing-library/react';
import PageToTest from './index';
import MenuPagina from '../MenuPagina/index';

test('renders component "Onderzoek aanmaken" without crashing', () => {
  render(<PageToTest />);
});

test('renders component "MenuPagina" without crashing', () => {
  render(<MenuPagina />);
});

test('updates state on input change', async () => {
  const { getByTestId } = render(<PageToTest />);
  const titleInput = getByTestId('title');
  const descInput = getByTestId('description');

  console.log(document.body.innerHTML);

  expect(titleInput.value).toBe(''); //veld moet leeg zijn

  fireEvent.change(titleInput, { target: { value: 'Snelheidstest' } });
  fireEvent.change(descInput, { target: { value: 'Hoe snel is onze website?' } });

  await waitFor(() => {
    expect(titleInput.value).toBe('Snelheidstest'); //veld moet aangepast zijn
    expect(descInput.value).toBe('Hoe snel is onze website?'); //veld moet aangepast zijn
  });
});


test('radiobutton check', async () => {
  const { getByTestId } = render(<PageToTest />);
  const FysiekInput = getByTestId('FysiekBox');
  const ZintuigInput = getByTestId('ZintuigelijkBox');
  const CognitiefInput = getByTestId('CognitiefBox');


  expect(FysiekInput.checked).toBeFalsy(); //velden moeten leeg zijn
  expect(ZintuigInput.checked).toBeFalsy();
  expect(CognitiefInput.checked).toBeFalsy();

  fireEvent.click(ZintuigInput); //pas zintuigeijk aan

  //zintuigelijk is true, de rest is false
  expect(ZintuigInput.checked).toBeTruthy(); //should be true
  expect(FysiekInput.checked).toBeFalsy(); //should be false
  expect(CognitiefInput.checked).toBeFalsy(); //should be false

  fireEvent.click(CognitiefInput); //pas cognitief aan

  await waitFor(() => {
    //cognitief moet nu true zijn, de rest automatic is false
    expect(ZintuigInput.checked).toBeFalsy();
    expect(FysiekInput.checked).toBeFalsy();
    expect(CognitiefInput.checked).toBeTruthy();
  });
});