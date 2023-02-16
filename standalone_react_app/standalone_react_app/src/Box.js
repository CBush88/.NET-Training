import "./Box.css"

export default function Box({ size, style, ...props }) {
    const sizeClassName = size? `box--${size}` : ''
    return (
        <div className={`box ${sizeClassName}`}
            style={{ fontStyle: 'italic', ...style }}>
            Box
        </div>)}