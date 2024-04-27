import classes from './IconWithSubtitle.module.css'
import Typography from "@mui/material/Typography";
import Icon from "@mui/material/Icon";
import {useEffect, useState} from "react";

// @ts-ignore
import {React} from 'react'

type onClickFunction = (props?: any) => any;
type setActiveCallback = React.Dispatch<React.SetStateAction<boolean>>;

interface Props{
    title: string;
    subtitle: string;
    icon: string;
    onClick?: onClickFunction;
    active: boolean;
    setActive: setActiveCallback;
}


const IconWithSubtitle = (props: Props) => {

    const [style, setStyle] = useState([classes.container]);

    useEffect(() => {
        if(props.active){
            setStyle([...style, classes.active])
        }else{
            setStyle([classes.container])
        }
    }, [props.active]);

    const clickHandler = () => {
        if(props.onClick){
            props.onClick()
        }
        props.setActive(!props.active)
    }

    return (
        // @ts-ignore
        <div className={style.join(' ')} onClick={(event) => clickHandler()}>
            <Icon sx={{color: '#FFFFFF'}} fontSize={'large'}>{props.icon}</Icon>
            <div className={classes.textContainer}>
                <Typography component={'h2'} className={classes.firstSlide}>{props.title}</Typography>
                <Typography variant={'body2'} className={classes.subtitle}>{props.subtitle}</Typography>
            </div>
        </div>
    );
};

export default IconWithSubtitle;