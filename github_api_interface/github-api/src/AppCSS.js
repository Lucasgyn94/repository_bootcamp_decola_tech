import { createGlobalStyle } from 'styled-components';
import dragonball from './images/dragonball.jpg';

export const GlobalStyle = createGlobalStyle`
  body {
    background: url(${dragonball}) center no-repeat;  
    background-size: cover;
    color: #332c36;
    padding: 0;
    margin: 0;
    font-family: 'New Tegomin', serif;
  }
`;