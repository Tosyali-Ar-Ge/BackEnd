import * as actionTypes from './actionTypes'

import initialState from './store'

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.UPDATE_LOGGED_USER:
            return {
                ...state,
                user: action.payload
            }
        default:
            return state
    }
}
export default reducer