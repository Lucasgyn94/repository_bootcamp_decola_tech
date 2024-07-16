import React from "react";
import * as S from './styled';
import { WrapperTittle } from "./styled";

export const RepositoryItem = ({name, linkToRepo, fullName}) => {
    return (
        <S.Wrapper>
            <WrapperTittle>{name}</WrapperTittle>
            <S.WrapperFullName>full name:</S.WrapperFullName>
            <S.WrapperLink 
                href={linkToRepo}
                target="_blank"
                rel="noreferrer"
            >
                {fullName}
            </S.WrapperLink>
        </S.Wrapper>
    );
};

// span = perído;