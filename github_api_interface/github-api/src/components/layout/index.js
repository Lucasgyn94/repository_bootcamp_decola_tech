import React from "react";
import Header from "../header";
import * as S from "./styled";


// criação layout que não muda

const Layout = ({children}) => {
    return (
        <S.WrapperLayout>
            <Header />
            {children}
        </S.WrapperLayout>
    );
};

export default Layout;