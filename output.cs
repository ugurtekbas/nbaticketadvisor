/*
! tailwindcss v3.3.3 | MIT License | https://tailwindcss.com
*/

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: #e5e7eb;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
5. Use the user's configured `sans` font-feature-settings by default.
6. Use the user's configured `sans` font-variation-settings by default.
*/

html {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  -moz-tab-size: 4;
  /* 3 */
  -o-tab-size: 4;
     tab-size: 4;
  /* 3 */
  font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
  font-feature-settings: normal;
  /* 5 */
  font-variation-settings: normal;
  /* 6 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-feature-settings: inherit;
  /* 1 */
  font-variation-settings: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  font-weight: inherit;
  /* 1 */
  line-height: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Reset default styling for dialogs.
*/

dialog {
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */

[hidden] {
  display: none;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

.container {
  width: 100%;
}

@media (min-width: 640px) {
  .container {
    max-width: 640px;
  }
}

@media (min-width: 768px) {
  .container {
    max-width: 768px;
  }
}

@media (min-width: 1024px) {
  .container {
    max-width: 1024px;
  }
}

@media (min-width: 1280px) {
  .container {
    max-width: 1280px;
  }
}

@media (min-width: 1536px) {
  .container {
    max-width: 1536px;
  }
}

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  padding: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  white-space: nowrap;
  border-width: 0;
}

.not-sr-only {
  position: static;
  width: auto;
  height: auto;
  padding: 0;
  margin: 0;
  overflow: visible;
  clip: auto;
  white-space: normal;
}

.pointer-events-none {
  pointer-events: none;
}

.pointer-events-auto {
  pointer-events: auto;
}

.visible {
  visibility: visible;
}

.invisible {
  visibility: hidden;
}

.collapse {
  visibility: collapse;
}

.static {
  position: static;
}

.fixed {
  position: fixed;
}

.absolute {
  position: absolute;
}

.relative {
  position: relative;
}

.sticky {
  position: sticky;
}

.-inset-1 {
  inset: -0.25rem;
}

.end-1 {
  inset-inline-end: 0.25rem;
}

.isolate {
  isolation: isolate;
}

.isolation-auto {
  isolation: auto;
}

.float-right {
  float: right;
}

.float-left {
  float: left;
}

.float-none {
  float: none;
}

.clear-left {
  clear: left;
}

.clear-right {
  clear: right;
}

.clear-both {
  clear: both;
}

.clear-none {
  clear: none;
}

.m-1 {
  margin: 0.25rem;
}

.mx-36 {
  margin-left: 9rem;
  margin-right: 9rem;
}

.mx-4 {
  margin-left: 1rem;
  margin-right: 1rem;
}

.mx-6 {
  margin-left: 1.5rem;
  margin-right: 1.5rem;
}

.mx-auto {
  margin-left: auto;
  margin-right: auto;
}

.my-11 {
  margin-top: 2.75rem;
  margin-bottom: 2.75rem;
}

.my-3 {
  margin-top: 0.75rem;
  margin-bottom: 0.75rem;
}

.my-6 {
  margin-top: 1.5rem;
  margin-bottom: 1.5rem;
}

.my-8 {
  margin-top: 2rem;
  margin-bottom: 2rem;
}

.mb-10 {
  margin-bottom: 2.5rem;
}

.mb-2 {
  margin-bottom: 0.5rem;
}

.mb-4 {
  margin-bottom: 1rem;
}

.mb-5 {
  margin-bottom: 1.25rem;
}

.mb-8 {
  margin-bottom: 2rem;
}

.mt-1 {
  margin-top: 0.25rem;
}

.mt-10 {
  margin-top: 2.5rem;
}

.mt-12 {
  margin-top: 3rem;
}

.mt-2 {
  margin-top: 0.5rem;
}

.box-border {
  box-sizing: border-box;
}

.box-content {
  box-sizing: content-box;
}

.line-clamp-none {
  overflow: visible;
  display: block;
  -webkit-box-orient: horizontal;
  -webkit-line-clamp: none;
}

.block {
  display: block;
}

.inline-block {
  display: inline-block;
}

.inline {
  display: inline;
}

.flex {
  display: flex;
}

.inline-flex {
  display: inline-flex;
}

.table {
  display: table;
}

.inline-table {
  display: inline-table;
}

.table-caption {
  display: table-caption;
}

.table-cell {
  display: table-cell;
}

.table-column {
  display: table-column;
}

.table-column-group {
  display: table-column-group;
}

.table-footer-group {
  display: table-footer-group;
}

.table-header-group {
  display: table-header-group;
}

.table-row-group {
  display: table-row-group;
}

.table-row {
  display: table-row;
}

.flow-root {
  display: flow-root;
}

.grid {
  display: grid;
}

.inline-grid {
  display: inline-grid;
}

.contents {
  display: contents;
}

.list-item {
  display: list-item;
}

.hidden {
  display: none;
}

.h-12 {
  height: 3rem;
}

.h-16 {
  height: 4rem;
}

.h-24 {
  height: 6rem;
}

.min-h-screen {
  min-height: 100vh;
}

.w-12 {
  width: 3rem;
}

.w-16 {
  width: 4rem;
}

.w-24 {
  width: 6rem;
}

.w-3\/4 {
  width: 75%;
}

.w-9\/12 {
  width: 75%;
}

.w-full {
  width: 100%;
}

.max-w-2xl {
  max-width: 42rem;
}

.flex-shrink {
  flex-shrink: 1;
}

.shrink {
  flex-shrink: 1;
}

.flex-grow {
  flex-grow: 1;
}

.grow {
  flex-grow: 1;
}

.table-auto {
  table-layout: auto;
}

.table-fixed {
  table-layout: fixed;
}

.caption-top {
  caption-side: top;
}

.caption-bottom {
  caption-side: bottom;
}

.border-collapse {
  border-collapse: collapse;
}

.border-separate {
  border-collapse: separate;
}

.\!transform {
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y)) !important;
}

.transform {
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.transform-cpu {
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.transform-gpu {
  transform: translate3d(var(--tw-translate-x), var(--tw-translate-y), 0) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.transform-none {
  transform: none;
}

.touch-auto {
  touch-action: auto;
}

.touch-none {
  touch-action: none;
}

.touch-pan-x {
  --tw-pan-x: pan-x;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-pan-left {
  --tw-pan-x: pan-left;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-pan-right {
  --tw-pan-x: pan-right;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-pan-y {
  --tw-pan-y: pan-y;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-pan-up {
  --tw-pan-y: pan-up;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-pan-down {
  --tw-pan-y: pan-down;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-pinch-zoom {
  --tw-pinch-zoom: pinch-zoom;
  touch-action: var(--tw-pan-x) var(--tw-pan-y) var(--tw-pinch-zoom);
}

.touch-manipulation {
  touch-action: manipulation;
}

.select-none {
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
}

.select-text {
  -webkit-user-select: text;
     -moz-user-select: text;
          user-select: text;
}

.select-all {
  -webkit-user-select: all;
     -moz-user-select: all;
          user-select: all;
}

.select-auto {
  -webkit-user-select: auto;
     -moz-user-select: auto;
          user-select: auto;
}

.resize-none {
  resize: none;
}

.resize-y {
  resize: vertical;
}

.resize-x {
  resize: horizontal;
}

.resize {
  resize: both;
}

.snap-none {
  scroll-snap-type: none;
}

.snap-x {
  scroll-snap-type: x var(--tw-scroll-snap-strictness);
}

.snap-y {
  scroll-snap-type: y var(--tw-scroll-snap-strictness);
}

.snap-both {
  scroll-snap-type: both var(--tw-scroll-snap-strictness);
}

.snap-mandatory {
  --tw-scroll-snap-strictness: mandatory;
}

.snap-proximity {
  --tw-scroll-snap-strictness: proximity;
}

.snap-start {
  scroll-snap-align: start;
}

.snap-end {
  scroll-snap-align: end;
}

.snap-center {
  scroll-snap-align: center;
}

.snap-align-none {
  scroll-snap-align: none;
}

.snap-normal {
  scroll-snap-stop: normal;
}

.snap-always {
  scroll-snap-stop: always;
}

.list-inside {
  list-style-position: inside;
}

.list-outside {
  list-style-position: outside;
}

.appearance-none {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.break-before-auto {
  -moz-column-break-before: auto;
       break-before: auto;
}

.break-before-avoid {
  -moz-column-break-before: avoid;
       break-before: avoid;
}

.break-before-all {
  -moz-column-break-before: all;
       break-before: all;
}

.break-before-avoid-page {
  -moz-column-break-before: avoid;
       break-before: avoid-page;
}

.break-before-page {
  -moz-column-break-before: page;
       break-before: page;
}

.break-before-left {
  -moz-column-break-before: left;
       break-before: left;
}

.break-before-right {
  -moz-column-break-before: right;
       break-before: right;
}

.break-before-column {
  -moz-column-break-before: column;
       break-before: column;
}

.break-inside-auto {
  -moz-column-break-inside: auto;
       break-inside: auto;
}

.break-inside-avoid {
  -moz-column-break-inside: avoid;
       break-inside: avoid;
}

.break-inside-avoid-page {
  break-inside: avoid-page;
}

.break-inside-avoid-column {
  -moz-column-break-inside: avoid;
       break-inside: avoid-column;
}

.break-after-auto {
  -moz-column-break-after: auto;
       break-after: auto;
}

.break-after-avoid {
  -moz-column-break-after: avoid;
       break-after: avoid;
}

.break-after-all {
  -moz-column-break-after: all;
       break-after: all;
}

.break-after-avoid-page {
  -moz-column-break-after: avoid;
       break-after: avoid-page;
}

.break-after-page {
  -moz-column-break-after: page;
       break-after: page;
}

.break-after-left {
  -moz-column-break-after: left;
       break-after: left;
}

.break-after-right {
  -moz-column-break-after: right;
       break-after: right;
}

.break-after-column {
  -moz-column-break-after: column;
       break-after: column;
}

.grid-flow-row {
  grid-auto-flow: row;
}

.grid-flow-col {
  grid-auto-flow: column;
}

.grid-flow-dense {
  grid-auto-flow: dense;
}

.grid-flow-row-dense {
  grid-auto-flow: row dense;
}

.grid-flow-col-dense {
  grid-auto-flow: column dense;
}

.flex-row {
  flex-direction: row;
}

.flex-row-reverse {
  flex-direction: row-reverse;
}

.flex-col {
  flex-direction: column;
}

.flex-col-reverse {
  flex-direction: column-reverse;
}

.flex-wrap {
  flex-wrap: wrap;
}

.flex-wrap-reverse {
  flex-wrap: wrap-reverse;
}

.flex-nowrap {
  flex-wrap: nowrap;
}

.place-content-center {
  place-content: center;
}

.place-content-start {
  place-content: start;
}

.place-content-end {
  place-content: end;
}

.place-content-between {
  place-content: space-between;
}

.place-content-around {
  place-content: space-around;
}

.place-content-evenly {
  place-content: space-evenly;
}

.place-content-baseline {
  place-content: baseline;
}

.place-content-stretch {
  place-content: stretch;
}

.place-items-start {
  place-items: start;
}

.place-items-end {
  place-items: end;
}

.place-items-center {
  place-items: center;
}

.place-items-baseline {
  place-items: baseline;
}

.place-items-stretch {
  place-items: stretch;
}

.content-normal {
  align-content: normal;
}

.content-center {
  align-content: center;
}

.content-start {
  align-content: flex-start;
}

.content-end {
  align-content: flex-end;
}

.content-between {
  align-content: space-between;
}

.content-around {
  align-content: space-around;
}

.content-evenly {
  align-content: space-evenly;
}

.content-baseline {
  align-content: baseline;
}

.content-stretch {
  align-content: stretch;
}

.items-start {
  align-items: flex-start;
}

.items-end {
  align-items: flex-end;
}

.items-center {
  align-items: center;
}

.items-baseline {
  align-items: baseline;
}

.items-stretch {
  align-items: stretch;
}

.justify-normal {
  justify-content: normal;
}

.justify-start {
  justify-content: flex-start;
}

.justify-end {
  justify-content: flex-end;
}

.justify-center {
  justify-content: center;
}

.justify-between {
  justify-content: space-between;
}

.justify-around {
  justify-content: space-around;
}

.justify-evenly {
  justify-content: space-evenly;
}

.justify-stretch {
  justify-content: stretch;
}

.justify-items-start {
  justify-items: start;
}

.justify-items-end {
  justify-items: end;
}

.justify-items-center {
  justify-items: center;
}

.justify-items-stretch {
  justify-items: stretch;
}

.space-x-2 > :not([hidden]) ~ :not([hidden]) {
  --tw-space-x-reverse: 0;
  margin-right: calc(0.5rem * var(--tw-space-x-reverse));
  margin-left: calc(0.5rem * calc(1 - var(--tw-space-x-reverse)));
}

.space-y-reverse > :not([hidden]) ~ :not([hidden]) {
  --tw-space-y-reverse: 1;
}

.space-x-reverse > :not([hidden]) ~ :not([hidden]) {
  --tw-space-x-reverse: 1;
}

.divide-x > :not([hidden]) ~ :not([hidden]) {
  --tw-divide-x-reverse: 0;
  border-right-width: calc(1px * var(--tw-divide-x-reverse));
  border-left-width: calc(1px * calc(1 - var(--tw-divide-x-reverse)));
}

.divide-y > :not([hidden]) ~ :not([hidden]) {
  --tw-divide-y-reverse: 0;
  border-top-width: calc(1px * calc(1 - var(--tw-divide-y-reverse)));
  border-bottom-width: calc(1px * var(--tw-divide-y-reverse));
}

.divide-y-reverse > :not([hidden]) ~ :not([hidden]) {
  --tw-divide-y-reverse: 1;
}

.divide-x-reverse > :not([hidden]) ~ :not([hidden]) {
  --tw-divide-x-reverse: 1;
}

.divide-solid > :not([hidden]) ~ :not([hidden]) {
  border-style: solid;
}

.divide-dashed > :not([hidden]) ~ :not([hidden]) {
  border-style: dashed;
}

.divide-dotted > :not([hidden]) ~ :not([hidden]) {
  border-style: dotted;
}

.divide-double > :not([hidden]) ~ :not([hidden]) {
  border-style: double;
}

.divide-none > :not([hidden]) ~ :not([hidden]) {
  border-style: none;
}

.place-self-auto {
  place-self: auto;
}

.place-self-start {
  place-self: start;
}

.place-self-end {
  place-self: end;
}

.place-self-center {
  place-self: center;
}

.place-self-stretch {
  place-self: stretch;
}

.self-auto {
  align-self: auto;
}

.self-start {
  align-self: flex-start;
}

.self-end {
  align-self: flex-end;
}

.self-center {
  align-self: center;
}

.self-stretch {
  align-self: stretch;
}

.self-baseline {
  align-self: baseline;
}

.justify-self-auto {
  justify-self: auto;
}

.justify-self-start {
  justify-self: start;
}

.justify-self-end {
  justify-self: end;
}

.justify-self-center {
  justify-self: center;
}

.justify-self-stretch {
  justify-self: stretch;
}

.overflow-auto {
  overflow: auto;
}

.overflow-hidden {
  overflow: hidden;
}

.overflow-clip {
  overflow: clip;
}

.overflow-visible {
  overflow: visible;
}

.overflow-scroll {
  overflow: scroll;
}

.overflow-x-auto {
  overflow-x: auto;
}

.overflow-y-auto {
  overflow-y: auto;
}

.overflow-x-hidden {
  overflow-x: hidden;
}

.overflow-y-hidden {
  overflow-y: hidden;
}

.overflow-x-clip {
  overflow-x: clip;
}

.overflow-y-clip {
  overflow-y: clip;
}

.overflow-x-visible {
  overflow-x: visible;
}

.overflow-y-visible {
  overflow-y: visible;
}

.overflow-x-scroll {
  overflow-x: scroll;
}

.overflow-y-scroll {
  overflow-y: scroll;
}

.overscroll-auto {
  overscroll-behavior: auto;
}

.overscroll-contain {
  overscroll-behavior: contain;
}

.overscroll-none {
  overscroll-behavior: none;
}

.overscroll-y-auto {
  overscroll-behavior-y: auto;
}

.overscroll-y-contain {
  overscroll-behavior-y: contain;
}

.overscroll-y-none {
  overscroll-behavior-y: none;
}

.overscroll-x-auto {
  overscroll-behavior-x: auto;
}

.overscroll-x-contain {
  overscroll-behavior-x: contain;
}

.overscroll-x-none {
  overscroll-behavior-x: none;
}

.scroll-auto {
  scroll-behavior: auto;
}

.scroll-smooth {
  scroll-behavior: smooth;
}

.truncate {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}

.overflow-ellipsis {
  text-overflow: ellipsis;
}

.text-ellipsis {
  text-overflow: ellipsis;
}

.text-clip {
  text-overflow: clip;
}

.hyphens-none {
  -webkit-hyphens: none;
          hyphens: none;
}

.hyphens-manual {
  -webkit-hyphens: manual;
          hyphens: manual;
}

.hyphens-auto {
  -webkit-hyphens: auto;
          hyphens: auto;
}

.whitespace-normal {
  white-space: normal;
}

.whitespace-nowrap {
  white-space: nowrap;
}

.whitespace-pre {
  white-space: pre;
}

.whitespace-pre-line {
  white-space: pre-line;
}

.whitespace-pre-wrap {
  white-space: pre-wrap;
}

.whitespace-break-spaces {
  white-space: break-spaces;
}

.break-normal {
  overflow-wrap: normal;
  word-break: normal;
}

.break-words {
  overflow-wrap: break-word;
}

.break-all {
  word-break: break-all;
}

.break-keep {
  word-break: keep-all;
}

.rounded {
  border-radius: 0.25rem;
}

.rounded-lg {
  border-radius: 0.5rem;
}

.rounded-xl {
  border-radius: 0.75rem;
}

.rounded-b {
  border-bottom-right-radius: 0.25rem;
  border-bottom-left-radius: 0.25rem;
}

.rounded-e {
  border-start-end-radius: 0.25rem;
  border-end-end-radius: 0.25rem;
}

.rounded-l {
  border-top-left-radius: 0.25rem;
  border-bottom-left-radius: 0.25rem;
}

.rounded-r {
  border-top-right-radius: 0.25rem;
  border-bottom-right-radius: 0.25rem;
}

.rounded-s {
  border-start-start-radius: 0.25rem;
  border-end-start-radius: 0.25rem;
}

.rounded-t {
  border-top-left-radius: 0.25rem;
  border-top-right-radius: 0.25rem;
}

.rounded-bl {
  border-bottom-left-radius: 0.25rem;
}

.rounded-br {
  border-bottom-right-radius: 0.25rem;
}

.rounded-ee {
  border-end-end-radius: 0.25rem;
}

.rounded-es {
  border-end-start-radius: 0.25rem;
}

.rounded-se {
  border-start-end-radius: 0.25rem;
}

.rounded-ss {
  border-start-start-radius: 0.25rem;
}

.rounded-tl {
  border-top-left-radius: 0.25rem;
}

.rounded-tr {
  border-top-right-radius: 0.25rem;
}

.border {
  border-width: 1px;
}

.border-x {
  border-left-width: 1px;
  border-right-width: 1px;
}

.border-y {
  border-top-width: 1px;
  border-bottom-width: 1px;
}

.border-b {
  border-bottom-width: 1px;
}

.border-e {
  border-inline-end-width: 1px;
}

.border-l {
  border-left-width: 1px;
}

.border-r {
  border-right-width: 1px;
}

.border-s {
  border-inline-start-width: 1px;
}

.border-t {
  border-top-width: 1px;
}

.border-solid {
  border-style: solid;
}

.border-dashed {
  border-style: dashed;
}

.border-dotted {
  border-style: dotted;
}

.border-double {
  border-style: double;
}

.border-hidden {
  border-style: hidden;
}

.border-none {
  border-style: none;
}

.border-amber-100 {
  --tw-border-opacity: 1;
  border-color: rgb(254 243 199 / var(--tw-border-opacity));
}

.bg-\[rgb\(255\2c 0\2c 0\)\] {
  --tw-bg-opacity: 1;
  background-color: rgb(255 0 0 / var(--tw-bg-opacity));
}

.bg-amber-100 {
  --tw-bg-opacity: 1;
  background-color: rgb(254 243 199 / var(--tw-bg-opacity));
}

.bg-neutral-200 {
  --tw-bg-opacity: 1;
  background-color: rgb(229 229 229 / var(--tw-bg-opacity));
}

.bg-orange-600 {
  --tw-bg-opacity: 1;
  background-color: rgb(234 88 12 / var(--tw-bg-opacity));
}

.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.bg-zinc-900 {
  --tw-bg-opacity: 1;
  background-color: rgb(24 24 27 / var(--tw-bg-opacity));
}

.decoration-slice {
  -webkit-box-decoration-break: slice;
          box-decoration-break: slice;
}

.decoration-clone {
  -webkit-box-decoration-break: clone;
          box-decoration-break: clone;
}

.box-decoration-slice {
  -webkit-box-decoration-break: slice;
          box-decoration-break: slice;
}

.box-decoration-clone {
  -webkit-box-decoration-break: clone;
          box-decoration-break: clone;
}

.bg-fixed {
  background-attachment: fixed;
}

.bg-local {
  background-attachment: local;
}

.bg-scroll {
  background-attachment: scroll;
}

.bg-clip-border {
  background-clip: border-box;
}

.bg-clip-padding {
  background-clip: padding-box;
}

.bg-clip-content {
  background-clip: content-box;
}

.bg-clip-text {
  -webkit-background-clip: text;
          background-clip: text;
}

.bg-repeat {
  background-repeat: repeat;
}

.bg-no-repeat {
  background-repeat: no-repeat;
}

.bg-repeat-x {
  background-repeat: repeat-x;
}

.bg-repeat-y {
  background-repeat: repeat-y;
}

.bg-repeat-round {
  background-repeat: round;
}

.bg-repeat-space {
  background-repeat: space;
}

.bg-origin-border {
  background-origin: border-box;
}

.bg-origin-padding {
  background-origin: padding-box;
}

.bg-origin-content {
  background-origin: content-box;
}

.object-contain {
  -o-object-fit: contain;
     object-fit: contain;
}

.object-cover {
  -o-object-fit: cover;
     object-fit: cover;
}

.object-fill {
  -o-object-fit: fill;
     object-fit: fill;
}

.object-none {
  -o-object-fit: none;
     object-fit: none;
}

.object-scale-down {
  -o-object-fit: scale-down;
     object-fit: scale-down;
}

.p-5 {
  padding: 1.25rem;
}

.p-7 {
  padding: 1.75rem;
}

.px-0 {
  padding-left: 0px;
  padding-right: 0px;
}

.px-2 {
  padding-left: 0.5rem;
  padding-right: 0.5rem;
}

.px-3 {
  padding-left: 0.75rem;
  padding-right: 0.75rem;
}

.px-4 {
  padding-left: 1rem;
  padding-right: 1rem;
}

.px-5 {
  padding-left: 1.25rem;
  padding-right: 1.25rem;
}

.px-6 {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}

.px-8 {
  padding-left: 2rem;
  padding-right: 2rem;
}

.py-12 {
  padding-top: 3rem;
  padding-bottom: 3rem;
}

.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.py-20 {
  padding-top: 5rem;
  padding-bottom: 5rem;
}

.py-4 {
  padding-top: 1rem;
  padding-bottom: 1rem;
}

.pb-10 {
  padding-bottom: 2.5rem;
}

.pb-6 {
  padding-bottom: 1.5rem;
}

.pb-8 {
  padding-bottom: 2rem;
}

.pt-10 {
  padding-top: 2.5rem;
}

.pt-3 {
  padding-top: 0.75rem;
}

.pt-4 {
  padding-top: 1rem;
}

.pt-7 {
  padding-top: 1.75rem;
}

.text-left {
  text-align: left;
}

.text-center {
  text-align: center;
}

.text-right {
  text-align: right;
}

.text-justify {
  text-align: justify;
}

.text-start {
  text-align: start;
}

.text-end {
  text-align: end;
}

.align-baseline {
  vertical-align: baseline;
}

.align-top {
  vertical-align: top;
}

.align-middle {
  vertical-align: middle;
}

.align-bottom {
  vertical-align: bottom;
}

.align-text-top {
  vertical-align: text-top;
}

.align-text-bottom {
  vertical-align: text-bottom;
}

.align-sub {
  vertical-align: sub;
}

.align-super {
  vertical-align: super;
}

.text-2xl {
  font-size: 1.5rem;
  line-height: 2rem;
}

.text-4xl {
  font-size: 2.25rem;
  line-height: 2.5rem;
}

.text-5xl {
  font-size: 3rem;
  line-height: 1;
}

.text-5xl\/\[52px\] {
  font-size: 3rem;
  line-height: 52px;
}

.text-xl {
  font-size: 1.25rem;
  line-height: 1.75rem;
}

.font-bold {
  font-weight: 700;
}

.font-semibold {
  font-weight: 600;
}

.uppercase {
  text-transform: uppercase;
}

.lowercase {
  text-transform: lowercase;
}

.capitalize {
  text-transform: capitalize;
}

.normal-case {
  text-transform: none;
}

.italic {
  font-style: italic;
}

.not-italic {
  font-style: normal;
}

.normal-nums {
  font-variant-numeric: normal;
}

.ordinal {
  --tw-ordinal: ordinal;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.slashed-zero {
  --tw-slashed-zero: slashed-zero;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.lining-nums {
  --tw-numeric-figure: lining-nums;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.oldstyle-nums {
  --tw-numeric-figure: oldstyle-nums;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.proportional-nums {
  --tw-numeric-spacing: proportional-nums;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.tabular-nums {
  --tw-numeric-spacing: tabular-nums;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.diagonal-fractions {
  --tw-numeric-fraction: diagonal-fractions;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.stacked-fractions {
  --tw-numeric-fraction: stacked-fractions;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.text-\[\#336699\]\/\[\.35\] {
  color: rgb(51 102 153 / .35);
}

.text-blue-500 {
  --tw-text-opacity: 1;
  color: rgb(59 130 246 / var(--tw-text-opacity));
}

.text-green-600 {
  --tw-text-opacity: 1;
  color: rgb(22 163 74 / var(--tw-text-opacity));
}

.text-orange-400 {
  --tw-text-opacity: 1;
  color: rgb(251 146 60 / var(--tw-text-opacity));
}

.text-rose-500 {
  --tw-text-opacity: 1;
  color: rgb(244 63 94 / var(--tw-text-opacity));
}

.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.text-zinc-100 {
  --tw-text-opacity: 1;
  color: rgb(244 244 245 / var(--tw-text-opacity));
}

.text-zinc-200 {
  --tw-text-opacity: 1;
  color: rgb(228 228 231 / var(--tw-text-opacity));
}

.underline {
  text-decoration-line: underline;
}

.overline {
  text-decoration-line: overline;
}

.line-through {
  text-decoration-line: line-through;
}

.no-underline {
  text-decoration-line: none;
}

.decoration-solid {
  text-decoration-style: solid;
}

.decoration-double {
  text-decoration-style: double;
}

.decoration-dotted {
  text-decoration-style: dotted;
}

.decoration-dashed {
  text-decoration-style: dashed;
}

.decoration-wavy {
  text-decoration-style: wavy;
}

.antialiased {
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.subpixel-antialiased {
  -webkit-font-smoothing: auto;
  -moz-osx-font-smoothing: auto;
}

.bg-blend-normal {
  background-blend-mode: normal;
}

.bg-blend-multiply {
  background-blend-mode: multiply;
}

.bg-blend-screen {
  background-blend-mode: screen;
}

.bg-blend-overlay {
  background-blend-mode: overlay;
}

.bg-blend-darken {
  background-blend-mode: darken;
}

.bg-blend-lighten {
  background-blend-mode: lighten;
}

.bg-blend-color-dodge {
  background-blend-mode: color-dodge;
}

.bg-blend-color-burn {
  background-blend-mode: color-burn;
}

.bg-blend-hard-light {
  background-blend-mode: hard-light;
}

.bg-blend-soft-light {
  background-blend-mode: soft-light;
}

.bg-blend-difference {
  background-blend-mode: difference;
}

.bg-blend-exclusion {
  background-blend-mode: exclusion;
}

.bg-blend-hue {
  background-blend-mode: hue;
}

.bg-blend-saturation {
  background-blend-mode: saturation;
}

.bg-blend-color {
  background-blend-mode: color;
}

.bg-blend-luminosity {
  background-blend-mode: luminosity;
}

.mix-blend-normal {
  mix-blend-mode: normal;
}

.mix-blend-multiply {
  mix-blend-mode: multiply;
}

.mix-blend-screen {
  mix-blend-mode: screen;
}

.mix-blend-overlay {
  mix-blend-mode: overlay;
}

.mix-blend-darken {
  mix-blend-mode: darken;
}

.mix-blend-lighten {
  mix-blend-mode: lighten;
}

.mix-blend-color-dodge {
  mix-blend-mode: color-dodge;
}

.mix-blend-color-burn {
  mix-blend-mode: color-burn;
}

.mix-blend-hard-light {
  mix-blend-mode: hard-light;
}

.mix-blend-soft-light {
  mix-blend-mode: soft-light;
}

.mix-blend-difference {
  mix-blend-mode: difference;
}

.mix-blend-exclusion {
  mix-blend-mode: exclusion;
}

.mix-blend-hue {
  mix-blend-mode: hue;
}

.mix-blend-saturation {
  mix-blend-mode: saturation;
}

.mix-blend-color {
  mix-blend-mode: color;
}

.mix-blend-luminosity {
  mix-blend-mode: luminosity;
}

.mix-blend-plus-lighter {
  mix-blend-mode: plus-lighter;
}

.\!shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1) !important;
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color) !important;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow) !important;
}

.shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.outline-none {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.outline {
  outline-style: solid;
}

.outline-dashed {
  outline-style: dashed;
}

.outline-dotted {
  outline-style: dotted;
}

.outline-double {
  outline-style: double;
}

.ring {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(3px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}

.ring-inset {
  --tw-ring-inset: inset;
}

.blur {
  --tw-blur: blur(8px);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow {
  --tw-drop-shadow: drop-shadow(0 1px 2px rgb(0 0 0 / 0.1)) drop-shadow(0 1px 1px rgb(0 0 0 / 0.06));
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.grayscale {
  --tw-grayscale: grayscale(100%);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.invert {
  --tw-invert: invert(100%);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.sepia {
  --tw-sepia: sepia(100%);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.\!filter {
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow) !important;
}

.filter {
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.filter-none {
  filter: none;
}

.backdrop-blur {
  --tw-backdrop-blur: blur(8px);
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
          backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.backdrop-grayscale {
  --tw-backdrop-grayscale: grayscale(100%);
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
          backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.backdrop-invert {
  --tw-backdrop-invert: invert(100%);
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
          backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.backdrop-sepia {
  --tw-backdrop-sepia: sepia(100%);
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
          backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.backdrop-filter {
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
          backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.backdrop-filter-none {
  -webkit-backdrop-filter: none;
          backdrop-filter: none;
}

.transition {
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.duration-300 {
  transition-duration: 300ms;
}

.ease-in {
  transition-timing-function: cubic-bezier(0.4, 0, 1, 1);
}

.ease-in-out {
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
}

.ease-out {
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
}

.content-\[\'this-is-also-valid\]-weirdly-enough\'\] {
  --tw-content: 'this-is-also-valid]-weirdly-enough';
  content: var(--tw-content);
}

@media (min-width: 640px) {
  .sm\:container {
    width: 100%;
  }

  @media (min-width: 640px) {
    .sm\:container {
      max-width: 640px;
    }
  }

  @media (min-width: 768px) {
    .sm\:container {
      max-width: 768px;
    }
  }

  @media (min-width: 1024px) {
    .sm\:container {
      max-width: 1024px;
    }
  }

  @media (min-width: 1280px) {
    .sm\:container {
      max-width: 1280px;
    }
  }

  @media (min-width: 1536px) {
    .sm\:container {
      max-width: 1536px;
    }
  }
}

.hover\:bg-orange-900:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(124 45 18 / var(--tw-bg-opacity));
}

.hover\:font-bold:hover {
  font-weight: 700;
}

.hover\:text-orange-400:hover {
  --tw-text-opacity: 1;
  color: rgb(251 146 60 / var(--tw-text-opacity));
}

.hover\:text-orange-700:hover {
  --tw-text-opacity: 1;
  color: rgb(194 65 12 / var(--tw-text-opacity));
}

.before\:hover\:text-center:hover::before {
  content: var(--tw-content);
  text-align: center;
}

.hover\:before\:text-center:hover::before {
  content: var(--tw-content);
  text-align: center;
}

.focus\:border-orange-500:focus {
  --tw-border-opacity: 1;
  border-color: rgb(249 115 22 / var(--tw-border-opacity));
}

.focus\:outline-none:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.focus\:hover\:text-center:hover:focus {
  text-align: center;
}

.hover\:focus\:text-center:focus:hover {
  text-align: center;
}

@media (min-width: 640px) {
  .sm\:w-8\/12 {
    width: 66.666667%;
  }

  .sm\:underline {
    text-decoration-line: underline;
  }

  @media not all and (min-width: 1024px) {
    .sm\:max-lg\:self-center {
      align-self: center;
    }
  }
}

@media (min-width: 768px) {
  .md\:mx-10 {
    margin-left: 2.5rem;
    margin-right: 2.5rem;
  }

  .md\:mx-8 {
    margin-left: 2rem;
    margin-right: 2rem;
  }

  .md\:my-16 {
    margin-top: 4rem;
    margin-bottom: 4rem;
  }

  .md\:w-1\/2 {
    width: 50%;
  }

  .md\:w-7\/12 {
    width: 58.333333%;
  }

  .md\:px-0 {
    padding-left: 0px;
    padding-right: 0px;
  }

  .md\:px-8 {
    padding-left: 2rem;
    padding-right: 2rem;
  }

  .md\:py-28 {
    padding-top: 7rem;
    padding-bottom: 7rem;
  }

  .md\:pb-16 {
    padding-bottom: 4rem;
  }

  .md\:pt-16 {
    padding-top: 4rem;
  }

  .md\:text-3xl {
    font-size: 1.875rem;
    line-height: 2.25rem;
  }

  .md\:text-6xl\/\[70px\] {
    font-size: 3.75rem;
    line-height: 70px;
  }
}

@media (min-width: 1024px) {
  .lg\:w-3\/12 {
    width: 25%;
  }

  .lg\:w-5\/12 {
    width: 41.666667%;
  }

  .lg\:flex-row {
    flex-direction: row;
  }

  .lg\:px-0 {
    padding-left: 0px;
    padding-right: 0px;
  }
}

@media (prefers-color-scheme: dark) {
  @media (min-width: 1024px) {
    .dark\:lg\:hover\:\[paint-order\:markers\]:hover {
      paint-order: markers;
    }
  }
}

@media (min-width: 1280px) {
  .xl\:w-2\/12 {
    width: 16.666667%;
  }
}