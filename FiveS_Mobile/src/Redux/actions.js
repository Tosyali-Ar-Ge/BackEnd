import * as actionTypes from './actionTypes'

const updateLoggedUser = (user) => {
    return {
        type: actionTypes.UPDATE_LOGGED_USER,
        payload: user
    };
};

export { updateLoggedUser }