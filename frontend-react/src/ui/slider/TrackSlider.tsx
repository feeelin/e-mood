import Slider from '@mui/material/Slider'
import {Box} from "@mui/material";

const TrackSlider = (props: any) => {
    return (
        <Box sx={{ width: '90%' }}>
            <Slider fullWidth {...props}></Slider>
        </Box>
    );
};

export default TrackSlider;