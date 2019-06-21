// ts2fable 0.0.0
module rec Fable.Pixi
open System
open Fable.Core
open Browser.Types
open Browser.Svg
open Fable

let [<Import("vertSize","pixi.js")>] vertSize: float = jsNative

module PIXI =
    let [<Import("accessibility","pixi.js/PIXI")>] accessibility: Accessibility.IExports = jsNative
    let [<Import("extract","pixi.js/PIXI")>] extract: Extract.IExports = jsNative
    let [<Import("extras","pixi.js/PIXI")>] extras: Extras.IExports = jsNative
    let [<Import("filters","pixi.js/PIXI")>] filters: Filters.IExports = jsNative
    let [<Import("interaction","pixi.js/PIXI")>] interaction: Interaction.IExports = jsNative
    let [<Import("LoaderResource","pixi.js/PIXI")>] loaderResource: LoaderResource.IExports = jsNative
    let [<Import("loaders","pixi.js/PIXI")>] loaders: Loaders.IExports = jsNative
    let [<Import("mesh","pixi.js/PIXI")>] mesh: Mesh.IExports = jsNative
    let [<Import("particles","pixi.js/PIXI")>] particles: Particles.IExports = jsNative
    let [<Import("prepare","pixi.js/PIXI")>] prepare: Prepare.IExports = jsNative
    let [<Import("resources","pixi.js/PIXI")>] resources: Resources.IExports = jsNative
    let [<Import("settings","pixi.js/PIXI")>] settings: Settings.IExports = jsNative
    let [<Import("systems","pixi.js/PIXI")>] systems: Systems.IExports = jsNative
    let [<Import("ticker","pixi.js/PIXI")>] ticker: Ticker.IExports = jsNative
    let [<Import("utils","pixi.js/PIXI")>] utils: Utils.IExports = jsNative
    let [<Import("*","pixi.js")>] pixi: IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract VERSION: string
        /// Deprecations (backward compatibilities) are automatically applied for browser bundles
        /// in the UMD module format. If using Webpack or Rollup, you'll need to apply these
        /// deprecations manually by doing something like this:
        abstract useDeprecated: unit -> unit
        //TODO abstract SVG_SIZE: U2<RegExp, string>
        abstract Transform: TransformStaticStatic
        abstract TransformBase: TransformBaseStatic
        abstract WebGLRenderer: WebGLRendererStatic
        abstract CanvasRenderTarget: CanvasRenderTargetStatic
        abstract loader: PIXI.Loader
        abstract FilterManager: FilterManagerStatic
        abstract Application: ApplicationStatic
        abstract AbstractRenderer: AbstractRendererStatic
        /// <summary>This helper function will automatically detect which renderer you should be using.
        /// WebGL is the preferred renderer as it is a lot faster. If WebGL is not supported by
        /// the browser then this function will return a canvas renderer</summary>
        /// <param name="options">- Parameter passed to webgl context, set to "high-performance"
        /// for devices with dual graphics card **webgl only**</param>
        abstract autoDetectRenderer: ?options: AutoDetectRendererOptions -> PIXI.Renderer
        abstract BatchBuffer: BatchBufferStatic
        abstract BatchDrawCall: BatchDrawCallStatic
        abstract BatchGeometry: BatchGeometryStatic
        abstract BatchPluginFactory: BatchPluginFactoryStatic
        abstract BatchRenderer: BatchRendererStatic
        abstract BatchShaderGenerator: BatchShaderGeneratorStatic
        abstract ObjectRenderer: ObjectRendererStatic
        abstract Filter: FilterStatic
        abstract SpriteMaskFilter: SpriteMaskFilterStatic
        abstract defaultVertex: string
        abstract defaultFilterVertex: string
        abstract Framebuffer: FramebufferStatic
        abstract Attribute: AttributeStatic
        abstract Buffer: BufferStatic
        abstract Geometry: GeometryStatic
        abstract Renderer: RendererStatic
        abstract BaseRenderTexture: BaseRenderTextureStatic
        abstract RenderTexture: RenderTextureStatic
        abstract GLProgram: GLProgramStatic
        abstract Program: ProgramStatic
        abstract Shader: ShaderStatic
        abstract UniformGroup: UniformGroupStatic
        abstract State: StateStatic
        abstract System: SystemStatic
        abstract BaseTexture: BaseTextureStatic
        abstract CubeTexture: CubeTextureStatic
        abstract GLTexture: GLTextureStatic
        abstract Texture: TextureStatic
        abstract TextureMatrix: TextureMatrixStatic
        abstract TextureUvs: TextureUvsStatic
        abstract Quad: QuadStatic
        abstract QuadUv: QuadUvStatic
        abstract Bounds: BoundsStatic
        abstract Container: ContainerStatic
        abstract DisplayObject: DisplayObjectStatic
        abstract GRAPHICS_CURVES: TypeLiteral_08
        abstract Graphics: GraphicsStatic
        abstract GraphicsData: GraphicsDataStatic
        abstract GraphicsGeometry: GraphicsGeometryStatic
        abstract FillStyle: FillStyleStatic
        abstract LineStyle: LineStyleStatic
        abstract Star: StarStatic
        abstract AppLoaderPlugin: AppLoaderPluginStatic
        abstract LoaderResource: LoaderResourceStatic
        abstract Loader: LoaderStatic
        abstract TextureLoader: TextureLoaderStatic
        abstract PI_2: float
        abstract RAD_TO_DEG: float
        abstract DEG_TO_RAD: float
        abstract SHAPES: TypeLiteral_09
        abstract GroupD8: GroupD8Static
        abstract Matrix: MatrixStatic
        abstract ObservablePoint: ObservablePointStatic
        abstract Point: PointStatic
        abstract Circle: CircleStatic
        abstract Ellipse: EllipseStatic
        abstract Polygon: PolygonStatic
        abstract Rectangle: RectangleStatic
        abstract RoundedRectangle: RoundedRectangleStatic
        //abstract Transform: TransformStatic
        abstract Mesh: MeshStatic
        abstract MeshBatchUvs: MeshBatchUvsStatic
        abstract MeshGeometry: MeshGeometryStatic
        abstract MeshMaterial: MeshMaterialStatic
        abstract RopeGeometry: RopeGeometryStatic
        abstract NineSlicePlane: NineSlicePlaneStatic
        abstract SimpleMesh: SimpleMeshStatic
        abstract SimplePlane: SimplePlaneStatic
        abstract SimpleRope: SimpleRopeStatic
        abstract ParticleContainer: ParticleContainerStatic
        abstract ParticleRenderer: ParticleRendererStatic
        abstract Runner: RunnerStatic
        abstract Sprite: SpriteStatic
        abstract AnimatedSprite: AnimatedSpriteStatic
        abstract TilingSprite: TilingSpriteStatic
        abstract TilingSpriteRenderer: TilingSpriteRendererStatic
        abstract Spritesheet: SpritesheetStatic
        abstract SpritesheetLoader: SpritesheetLoaderStatic
        abstract TEXT_GRADIENT: TypeLiteral_10
        abstract Text: TextStatic
        abstract TextMetrics: TextMetricsStatic
        abstract TextStyle: TextStyleStatic
        abstract BitmapFontLoader: BitmapFontLoaderStatic
        abstract BitmapText: BitmapTextStatic
        abstract UPDATE_PRIORITY: TypeLiteral_11
        abstract Ticker: TickerStatic
        abstract TickerPlugin: TickerPluginStatic
        //TODO abstract DATA_URI: U2<RegExp, string>

    type [<AllowNullLiteral>] AutoDetectRendererOptions =
        abstract width: float option with get, set
        abstract height: float option with get, set
        //TODO abstract view: Browser.Dom.Browser.Types.HTMLCanvasElement option with get, set
        abstract transparent: bool option with get, set
        abstract autoDensity: bool option with get, set
        abstract antialias: bool option with get, set
        abstract preserveDrawingBuffer: bool option with get, set
        abstract backgroundColor: float option with get, set
        abstract clearBeforeRender: bool option with get, set
        abstract resolution: float option with get, set
        abstract forceCanvas: bool option with get, set
        abstract forceFXAA: bool option with get, set
        abstract powerPreference: string option with get, set

(* ===================================== TODO =====================================*)
    
    // Need Faable.Browser.WEBGl bindings
    type Symbol = obj
    type Error = obj
    type WebGLProgram = obj
    type WebGLContextEvent = obj
    (*
    type [<AllowNullLiteral>] TypeLiteral_01 =
        abstract drawBuffers: WEBGL_draw_buffers with get, set
        abstract depthTexture: WEBGL_depth_texture with get, set
        abstract floatTexture: OES_texture_float with get, set
        abstract loseContext: WEBGL_lose_context with get, set
        abstract vertexArrayObject: OES_vertex_array_object with get, set
        abstract anisotropicFiltering: EXT_texture_filter_anisotropic with get, set
    *)


(* ===================================== TODO =====================================*)

    module Filters =

        type [<AllowNullLiteral>] IExports =
            abstract BlurXFilter: BlurXFilterStatic
            abstract BlurYFilter: BlurYFilterStatic
            abstract AlphaFilter: AlphaFilterStatic
            abstract BlurFilter: BlurFilterStatic
            abstract BlurFilterPass: BlurFilterPassStatic
            abstract ColorMatrixFilter: ColorMatrixFilterStatic
            abstract DisplacementFilter: DisplacementFilterStatic
            abstract FXAAFilter: FXAAFilterStatic
            abstract NoiseFilter: NoiseFilterStatic

        type [<AllowNullLiteral>] BlurXFilter =
            interface end

        type [<AllowNullLiteral>] BlurXFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> BlurXFilter

        type [<AllowNullLiteral>] BlurYFilter =
            interface end


        type [<AllowNullLiteral>] BlurYFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> BlurYFilter

        /// Simplest filter - applies alpha.
        /// 
        /// Use this instead of Container's alpha property to avoid visual layering of individual elements.
        /// AlphaFilter applies alpha evenly across the entire display object and any opaque elements it contains.
        /// If elements are not opaque, they will blend with each other anyway.
        /// 
        /// Very handy if you want to use common features of all filters:
        /// 
        /// 1. Assign a blendMode to this filter, blend all elements inside display object with background.
        /// 
        /// 2. To use clipping in display coordinates, assign a filterArea to the same container that has this filter.
        type [<AllowNullLiteral>] AlphaFilter =
            inherit PIXI.Filter
            /// Coefficient for alpha multiplication
            abstract alpha: float with get, set
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// <summary>Applies the filter</summary>
            /// <param name="filterManager">- The renderer to retrieve the filter from</param>
            /// <param name="input">- The input render target.</param>
            /// <param name="output">- The target to output to.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it</param>
            /// <param name="currentState">- It's current state of filter.
            /// There are some useful properties in the currentState :
            /// target, filters, sourceFrame, destinationFrame, renderTarget, resolution</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool * ?currentState: obj -> unit
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// Simplest filter - applies alpha.
        /// 
        /// Use this instead of Container's alpha property to avoid visual layering of individual elements.
        /// AlphaFilter applies alpha evenly across the entire display object and any opaque elements it contains.
        /// If elements are not opaque, they will blend with each other anyway.
        /// 
        /// Very handy if you want to use common features of all filters:
        /// 
        /// 1. Assign a blendMode to this filter, blend all elements inside display object with background.
        /// 
        /// 2. To use clipping in display coordinates, assign a filterArea to the same container that has this filter.
        type [<AllowNullLiteral>] AlphaFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: ?alpha: float -> AlphaFilter

        /// The BlurFilter applies a Gaussian blur to an object.
        /// 
        /// The strength of the blur can be set for the x-axis and y-axis separately.
        type [<AllowNullLiteral>] BlurFilter =
            inherit PIXI.Filter
            /// <summary>Applies the filter.</summary>
            /// <param name="filterManager">- The manager.</param>
            /// <param name="input">- The input target.</param>
            /// <param name="output">- The output target.</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture -> unit
            /// Sets the strength of both the blurX and blurY properties simultaneously
            abstract blur: float with get, set
            /// Sets the number of passes for blur. More passes means higher quaility bluring.
            abstract quality: float with get, set
            /// Sets the strength of the blurX property
            abstract blurX: float with get, set
            /// Sets the strength of the blurY property
            abstract blurY: float with get, set
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// If set to true the edge of the target will be clamped
            abstract repeatEdgePixels: bool with get, set
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// The BlurFilter applies a Gaussian blur to an object.
        /// 
        /// The strength of the blur can be set for the x-axis and y-axis separately.
        type [<AllowNullLiteral>] BlurFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: ?strength: float * ?quality: float * ?resolution: float * ?kernelSize: float -> BlurFilter

        /// The BlurFilterPass applies a horizontal or vertical Gaussian blur to an object.
        type [<AllowNullLiteral>] BlurFilterPass =
            inherit PIXI.Filter
            /// Sets the strength of both the blur.
            abstract blur: float with get, set
            /// Sets the quality of the blur by modifying the number of passes. More passes means higher
            /// quaility bluring but the lower the performance.
            abstract quality: float with get, set
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// <summary>Applies the filter</summary>
            /// <param name="filterManager">- The renderer to retrieve the filter from</param>
            /// <param name="input">- The input render target.</param>
            /// <param name="output">- The target to output to.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it</param>
            /// <param name="currentState">- It's current state of filter.
            /// There are some useful properties in the currentState :
            /// target, filters, sourceFrame, destinationFrame, renderTarget, resolution</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool * ?currentState: obj -> unit
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// The BlurFilterPass applies a horizontal or vertical Gaussian blur to an object.
        type [<AllowNullLiteral>] BlurFilterPassStatic =
            [<Emit "new $0($1...)">] abstract Create: horizontal: bool * strength: float * quality: float * resolution: float * ?kernelSize: float -> BlurFilterPass

        /// The ColorMatrixFilter class lets you apply a 5x4 matrix transformation on the RGBA
        /// color and alpha values of every pixel on your displayObject to produce a result
        /// with a new set of RGBA color and alpha values. It's pretty powerful!
        /// 
        /// ```js
        ///   let colorMatrix = new PIXI.filters.ColorMatrixFilter();
        ///   container.filters = [colorMatrix];
        ///   colorMatrix.contrast(2);
        /// ```
        type [<AllowNullLiteral>] ColorMatrixFilter =
            inherit PIXI.Filter
            /// <summary>Transforms current matrix and set the new one</summary>
            /// <param name="matrix">- 5x4 matrix</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract _loadMatrix: matrix: ResizeArray<float> * multiply: bool -> unit
            /// <summary>Adjusts brightness</summary>
            /// <param name="b">- value of the brigthness (0-1, where 0 is black)</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract brightness: b: float * multiply: bool -> unit
            /// <summary>Set the matrices in grey scales</summary>
            /// <param name="scale">- value of the grey (0-1, where 0 is black)</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract greyscale: scale: float * multiply: bool -> unit
            /// <summary>Set the black and white matrice.</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract blackAndWhite: multiply: bool -> unit
            /// <summary>Set the hue property of the color</summary>
            /// <param name="rotation">- in degrees</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract hue: rotation: float * multiply: bool -> unit
            /// <summary>Set the contrast matrix, increase the separation between dark and bright
            /// Increase contrast : shadows darker and highlights brighter
            /// Decrease contrast : bring the shadows up and the highlights down</summary>
            /// <param name="amount">- value of the contrast (0-1)</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract contrast: amount: float * multiply: bool -> unit
            /// <summary>Set the saturation matrix, increase the separation between colors
            /// Increase saturation : increase contrast, brightness, and sharpness</summary>
            /// <param name="amount">- The saturation amount (0-1)</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract saturate: amount: float * multiply: bool -> unit
            /// Desaturate image (remove color)
            /// 
            /// Call the saturate function
            abstract desaturate: unit -> unit
            /// <summary>Negative image (inverse of classic rgb matrix)</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract negative: multiply: bool -> unit
            /// <summary>Sepia image</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract sepia: multiply: bool -> unit
            /// <summary>Color motion picture process invented in 1916 (thanks Dominic Szablewski)</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract technicolor: multiply: bool -> unit
            /// <summary>Polaroid filter</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract polaroid: multiply: bool -> unit
            /// <summary>Filter who transforms : Red -> Blue and Blue -> Red</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract toBGR: multiply: bool -> unit
            /// <summary>Color reversal film introduced by Eastman Kodak in 1935. (thanks Dominic Szablewski)</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract kodachrome: multiply: bool -> unit
            /// <summary>Brown delicious browni filter (thanks Dominic Szablewski)</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract browni: multiply: bool -> unit
            /// <summary>Vintage filter (thanks Dominic Szablewski)</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract vintage: multiply: bool -> unit
            /// <summary>We don't know exactly what it does, kind of gradient map, but funny to play with!</summary>
            /// <param name="desaturation">- Tone values.</param>
            /// <param name="toned">- Tone values.</param>
            /// <param name="lightColor">- Tone values, example: `0xFFE580`</param>
            /// <param name="darkColor">- Tone values, example: `0xFFE580`</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract colorTone: desaturation: float * toned: float * lightColor: string * darkColor: string * multiply: bool -> unit
            /// <summary>Night effect</summary>
            /// <param name="intensity">- The intensity of the night effect.</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract night: intensity: float * multiply: bool -> unit
            /// <summary>Predator effect
            /// 
            /// Erase the current matrix by setting a new indepent one</summary>
            /// <param name="amount">- how much the predator feels his future victim</param>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract predator: amount: float * multiply: bool -> unit
            /// <summary>LSD effect
            /// 
            /// Multiply the current matrix</summary>
            /// <param name="multiply">- if true, current matrix and matrix are multiplied. If false,
            /// just set the current matrix with </param>
            abstract lsd: multiply: bool -> unit
            /// Erase the current matrix by setting the default one
            abstract reset: unit -> unit
            /// The matrix of the color matrix filter
            abstract matrix: ResizeArray<float> with get, set
            /// The opacity value to use when mixing the original and resultant colors.
            /// 
            /// When the value is 0, the original color is used without modification.
            /// When the value is 1, the result color is used.
            /// When in the range (0, 1) the color is interpolated between the original and result by this amount.
            abstract alpha: float with get, set
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// <summary>Applies the filter</summary>
            /// <param name="filterManager">- The renderer to retrieve the filter from</param>
            /// <param name="input">- The input render target.</param>
            /// <param name="output">- The target to output to.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it</param>
            /// <param name="currentState">- It's current state of filter.
            /// There are some useful properties in the currentState :
            /// target, filters, sourceFrame, destinationFrame, renderTarget, resolution</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool * ?currentState: obj -> unit
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// The ColorMatrixFilter class lets you apply a 5x4 matrix transformation on the RGBA
        /// color and alpha values of every pixel on your displayObject to produce a result
        /// with a new set of RGBA color and alpha values. It's pretty powerful!
        /// 
        /// ```js
        ///   let colorMatrix = new PIXI.filters.ColorMatrixFilter();
        ///   container.filters = [colorMatrix];
        ///   colorMatrix.contrast(2);
        /// ```
        type [<AllowNullLiteral>] ColorMatrixFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ColorMatrixFilter

        /// The DisplacementFilter class uses the pixel values from the specified texture
        /// (called the displacement map) to perform a displacement of an object.
        /// 
        /// You can use this filter to apply all manor of crazy warping effects.
        /// Currently the `r` property of the texture is used to offset the `x`
        /// and the `g` property of the texture is used to offset the `y`.
        /// 
        /// The way it works is it uses the values of the displacement map to look up the
        /// correct pixels to output. This means it's not technically moving the original.
        /// Instead, it's starting at the output and asking "which pixel from the original goes here".
        /// For example, if a displacement map pixel has `red = 1` and the filter scale is `20`,
        /// this filter will output the pixel approximately 20 pixels to the right of the original.
        type [<AllowNullLiteral>] DisplacementFilter =
            inherit PIXI.Filter
            /// scaleX, scaleY for displacements
            abstract scale: PIXI.Point with get, set
            /// <summary>Applies the filter.</summary>
            /// <param name="filterManager">- The manager.</param>
            /// <param name="input">- The input target.</param>
            /// <param name="output">- The output target.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it.</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool -> unit
            /// The texture used for the displacement map. Must be power of 2 sized texture.
            abstract map: PIXI.Texture with get, set
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// The DisplacementFilter class uses the pixel values from the specified texture
        /// (called the displacement map) to perform a displacement of an object.
        /// 
        /// You can use this filter to apply all manor of crazy warping effects.
        /// Currently the `r` property of the texture is used to offset the `x`
        /// and the `g` property of the texture is used to offset the `y`.
        /// 
        /// The way it works is it uses the values of the displacement map to look up the
        /// correct pixels to output. This means it's not technically moving the original.
        /// Instead, it's starting at the output and asking "which pixel from the original goes here".
        /// For example, if a displacement map pixel has `red = 1` and the filter scale is `20`,
        /// this filter will output the pixel approximately 20 pixels to the right of the original.
        type [<AllowNullLiteral>] DisplacementFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: sprite: PIXI.Sprite * ?scale: float -> DisplacementFilter

        /// Basic FXAA (Fast Approximate Anti-Aliasing) implementation based on the code on geeks3d.com
        /// with the modification that the texture2DLod stuff was removed since it is unsupported by WebGL.
        type [<AllowNullLiteral>] FXAAFilter =
            inherit PIXI.Filter
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// <summary>Applies the filter</summary>
            /// <param name="filterManager">- The renderer to retrieve the filter from</param>
            /// <param name="input">- The input render target.</param>
            /// <param name="output">- The target to output to.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it</param>
            /// <param name="currentState">- It's current state of filter.
            /// There are some useful properties in the currentState :
            /// target, filters, sourceFrame, destinationFrame, renderTarget, resolution</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool * ?currentState: obj -> unit
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// Basic FXAA (Fast Approximate Anti-Aliasing) implementation based on the code on geeks3d.com
        /// with the modification that the texture2DLod stuff was removed since it is unsupported by WebGL.
        type [<AllowNullLiteral>] FXAAFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> FXAAFilter

        /// A Noise effect filter.
        type [<AllowNullLiteral>] NoiseFilter =
            inherit PIXI.Filter
            /// The amount of noise to apply, this value should be in the range (0, 1].
            abstract noise: float with get, set
            /// A seed value to apply to the random noise generation. `Math.random()` is a good value to use.
            abstract seed: float with get, set
            /// The padding of the filter. Some filters require extra space to breath such as a blur.
            /// Increasing this will add extra width and height to the bounds of the object that the
            /// filter is applied to.
            abstract padding: float with get, set
            /// The resolution of the filter. Setting this to be lower will lower the quality but
            /// increase the performance of the filter.
            abstract resolution: float with get, set
            /// If enabled is true the filter is applied, if false it will not.
            abstract enabled: bool with get, set
            /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
            /// Switch it off if it does not work for specific shader.
            abstract autoFit: bool with get, set
            /// Legacy filters use position and uvs from attributes
            abstract legacy: bool
            /// The WebGL state the filter requires to render
            abstract state: PIXI.State with get, set
            /// <summary>Applies the filter</summary>
            /// <param name="filterManager">- The renderer to retrieve the filter from</param>
            /// <param name="input">- The input render target.</param>
            /// <param name="output">- The target to output to.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it</param>
            /// <param name="currentState">- It's current state of filter.
            /// There are some useful properties in the currentState :
            /// target, filters, sourceFrame, destinationFrame, renderTarget, resolution</param>
            abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool * ?currentState: obj -> unit
            /// Sets the blendmode of the filter
            abstract blendMode: float with get, set
            /// Shader uniform values, shortcut for `uniformGroup.uniforms`
            abstract uniforms: obj option

        /// A Noise effect filter.
        type [<AllowNullLiteral>] NoiseFilterStatic =
            [<Emit "new $0($1...)">] abstract Create: ?noise: float * ?seed: float -> NoiseFilter

    type [<AllowNullLiteral>] TransformStatic =
        interface end

    type [<AllowNullLiteral>] TransformStaticStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TransformStatic

    type [<AllowNullLiteral>] TransformBase =
        interface end

    type [<AllowNullLiteral>] TransformBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TransformBase

    type TRANSFORM_MODE =
        obj

    type [<AllowNullLiteral>] WebGLRenderer =
        interface end

    type [<AllowNullLiteral>] WebGLRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebGLRenderer

    type [<AllowNullLiteral>] CanvasRenderTarget =
        interface end

    type [<AllowNullLiteral>] CanvasRenderTargetStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CanvasRenderTarget

    type [<AllowNullLiteral>] FilterManager =
        abstract getRenderTarget: unit -> unit
        abstract returnRenderTarget: unit -> unit

    type [<AllowNullLiteral>] FilterManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FilterManager

    module Extras =

        type [<AllowNullLiteral>] IExports =
            abstract TilingSprite: TilingSpriteStatic
            abstract TilingSpriteRenderer: TilingSpriteRendererStatic
            abstract AnimatedSprite: AnimatedSpriteStatic
            abstract BitmapText: BitmapTextStatic

        type [<AllowNullLiteral>] TilingSprite =
            interface end

        type [<AllowNullLiteral>] TilingSpriteStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> TilingSprite

        type [<AllowNullLiteral>] TilingSpriteRenderer =
            interface end

        type [<AllowNullLiteral>] TilingSpriteRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> TilingSpriteRenderer

        type [<AllowNullLiteral>] AnimatedSprite =
            interface end

        type [<AllowNullLiteral>] AnimatedSpriteStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> AnimatedSprite

        type [<AllowNullLiteral>] BitmapText =
            interface end

        type [<AllowNullLiteral>] BitmapTextStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> BitmapText

    module Mesh =

        type [<AllowNullLiteral>] IExports =
            abstract Mesh: MeshStatic
            abstract NineSlicePlane: NineSlicePlaneStatic
            abstract Plane: PlaneStatic
            abstract Rope: RopeStatic
            abstract RawMesh: RawMeshStatic
            abstract CanvasMeshRenderer: CanvasMeshRendererStatic
            abstract MeshRenderer: MeshRendererStatic

        type [<AllowNullLiteral>] Mesh =
            interface end

        type [<AllowNullLiteral>] MeshStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Mesh

        type [<AllowNullLiteral>] NineSlicePlane =
            interface end

        type [<AllowNullLiteral>] NineSlicePlaneStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> NineSlicePlane

        type [<AllowNullLiteral>] Plane =
            interface end

        type [<AllowNullLiteral>] PlaneStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Plane

        type [<AllowNullLiteral>] Rope =
            interface end

        type [<AllowNullLiteral>] RopeStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Rope

        type [<AllowNullLiteral>] RawMesh =
            interface end

        type [<AllowNullLiteral>] RawMeshStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> RawMesh

        type [<AllowNullLiteral>] CanvasMeshRenderer =
            interface end

        type [<AllowNullLiteral>] CanvasMeshRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> CanvasMeshRenderer

        type [<AllowNullLiteral>] MeshRenderer =
            interface end

        type [<AllowNullLiteral>] MeshRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> MeshRenderer

    module Particles =

        type [<AllowNullLiteral>] IExports =
            abstract ParticleContainer: ParticleContainerStatic
            abstract ParticleRenderer: ParticleRendererStatic

        type [<AllowNullLiteral>] ParticleContainer =
            interface end

        type [<AllowNullLiteral>] ParticleContainerStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ParticleContainer

        type [<AllowNullLiteral>] ParticleRenderer =
            interface end

        type [<AllowNullLiteral>] ParticleRendererStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ParticleRenderer

    module Ticker =

        type [<AllowNullLiteral>] IExports =
            abstract Ticker: TickerStatic
            abstract shared: PIXI.Ticker

        type [<AllowNullLiteral>] Ticker =
            interface end

        type [<AllowNullLiteral>] TickerStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Ticker

    module Loaders =

        type [<AllowNullLiteral>] IExports =
            abstract Loader: LoaderStatic
            abstract Resource: ResourceStatic
            abstract bitmapFontParser: unit -> unit
            abstract parseBitmapFontData: unit -> unit
            abstract spritesheetParser: unit -> unit
            abstract getResourcePath: unit -> unit

        type [<AllowNullLiteral>] Loader =
            interface end

        type [<AllowNullLiteral>] LoaderStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Loader
            /// <param name="middleware"></param>
            abstract addPixiMiddleware: middleware: (ResizeArray<obj option> -> obj option) -> unit

        type [<AllowNullLiteral>] Resource =
            interface end

        type [<AllowNullLiteral>] ResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Resource

    module Accessibility =

        type [<AllowNullLiteral>] IExports =
            abstract AccessibilityManager: AccessibilityManagerStatic

        /// The Accessibility manager recreates the ability to tab and have content read by screen readers.
        /// This is very important as it can possibly help people with disabilities access PixiJS content.
        /// 
        /// A DisplayObject can be made accessible just like it can be made interactive. This manager will map the
        /// events as if the mouse was being used, minimizing the effort required to implement.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.accessibility`
        type [<AllowNullLiteral>] AccessibilityManager =
            /// Setting this to true will visually show the divs.
            abstract debug: bool with get, set
            /// The renderer this accessibility manager works for.
            abstract renderer: PIXI.AbstractRenderer with get, set
            /// A flag
            abstract isActive: bool
            /// A flag
            abstract isMobileAccessibility: bool
            /// <summary>Adjust the hit area based on the bounds of a display object</summary>
            /// <param name="hitArea">- Bounds of the child</param>
            abstract capHitArea: hitArea: PIXI.Rectangle -> unit
            /// Destroys the accessibility manager
            abstract destroy: unit -> unit

        /// The Accessibility manager recreates the ability to tab and have content read by screen readers.
        /// This is very important as it can possibly help people with disabilities access PixiJS content.
        /// 
        /// A DisplayObject can be made accessible just like it can be made interactive. This manager will map the
        /// events as if the mouse was being used, minimizing the effort required to implement.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.accessibility`
        type [<AllowNullLiteral>] AccessibilityManagerStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> AccessibilityManager

    /// Convenience class to create a new PIXI application.
    /// 
    /// This class automatically creates the renderer, ticker and root container.
    type [<AllowNullLiteral>] Application =
        /// WebGL renderer if available, otherwise CanvasRenderer.
        abstract renderer: PIXI.Renderer with get, set
        /// The root display container that's rendered.
        abstract stage: PIXI.Container with get, set
        /// Render the current stage.
        abstract render: unit -> unit
        /// Reference to the renderer's canvas element.
        abstract view: HTMLCanvasElement
        /// Reference to the renderer's screen rectangle. Its safe to use as `filterArea` or `hitArea` for the whole screen.
        abstract screen: PIXI.Rectangle
        /// <summary>Destroy and don't use after this.</summary>
        /// <param name="removeView">Automatically remove canvas from DOM.</param>
        /// <param name="stageOptions">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?removeView: bool * ?stageOptions: ApplicationDestroyStageOptions -> unit
        /// The element or window to resize the application to.
        //TODO  abstract resizeTo: Browser.Types.HTMLElement with get, set
        /// If `resizeTo` is set, calling this function
        /// will resize to the width and height of that element.
        abstract resize: unit -> unit
        /// Loader instance to help with asset loading.
        abstract loader: PIXI.Loader
        /// Convenience method for stopping the render.
        abstract stop: unit -> unit
        /// Convenience method for starting the render.
        abstract start: unit -> unit
        /// Ticker for doing render updates.
        abstract ticker: PIXI.Ticker with get, set

    type [<AllowNullLiteral>] ApplicationDestroyStageOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// Convenience class to create a new PIXI application.
    /// 
    /// This class automatically creates the renderer, ticker and root container.
    type [<AllowNullLiteral>] ApplicationStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: ApplicationStaticOptions -> Application
        /// <summary>Register a middleware plugin for the application</summary>
        /// <param name="plugin">- Plugin being installed</param>
        abstract registerPlugin: plugin: PIXI.Application.Plugin -> unit

    type [<AllowNullLiteral>] ApplicationStaticOptions =
        abstract autoStart: bool option with get, set
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract view: HTMLCanvasElement option with get, set
        abstract transparent: bool option with get, set
        abstract autoDensity: bool option with get, set
        abstract antialias: bool option with get, set
        abstract preserveDrawingBuffer: bool option with get, set
        abstract resolution: float option with get, set
        abstract forceCanvas: bool option with get, set
        abstract backgroundColor: float option with get, set
        abstract clearBeforeRender: bool option with get, set
        abstract forceFXAA: bool option with get, set
        abstract powerPreference: string option with get, set
        abstract sharedTicker: bool option with get, set
        abstract sharedLoader: bool option with get, set
        //abstract resizeTo: U2<Window, Browser.Types.HTMLElement> option with get, set
        abstract resizeTo: Browser.Types.HTMLElement option with get, set

    module Application =

        type [<AllowNullLiteral>] Plugin =
            abstract init: (ResizeArray<obj option> -> obj option) with get, set
            abstract destroy: (ResizeArray<obj option> -> obj option) with get, set

    type ENV =
        obj

    type RENDERER_TYPE =
        obj

    type BLEND_MODES =
        obj

    type DRAW_MODES =
        obj

    type FORMATS =
        obj

    type TARGETS =
        obj

    type TYPES =
        obj

    type SCALE_MODES =
        obj

    type WRAP_MODES =
        obj

    type MIPMAP_MODES =
        obj

    type GC_MODES =
        obj

    type PRECISION =
        obj

    /// The AbstractRenderer is the base for a PixiJS Renderer. It is extended by the {@link PIXI.CanvasRenderer}
    /// and {@link PIXI.Renderer} which can be used for rendering a PixiJS scene.
    type [<AllowNullLiteral>] AbstractRenderer =
        inherit PIXI.Utils.EventEmitter
        abstract autoResize: bool with get, set
        /// The supplied constructor options.
        abstract options: obj option
        /// The type of the renderer.
        abstract ``type``: float with get, set
        /// Measurements of the screen. (0, 0, screenWidth, screenHeight).
        /// 
        /// Its safe to use as filterArea or hitArea for the whole stage.
        abstract screen: PIXI.Rectangle with get, set
        /// The canvas element that everything is drawn to.
        abstract view: Browser.Types.HTMLCanvasElement with get, set
        /// The resolution / device pixel ratio of the renderer.
        abstract resolution: float with get, set
        /// Whether the render view is transparent.
        abstract transparent: bool with get, set
        /// Whether CSS dimensions of canvas view should be resized to screen dimensions automatically.
        abstract autoDensity: bool with get, set
        /// The value of the preserveDrawingBuffer flag affects whether or not the contents of
        /// the stencil buffer is retained after rendering.
        abstract preserveDrawingBuffer: bool with get, set
        /// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
        /// If the scene is NOT transparent PixiJS will use a canvas sized fillRect operation every
        /// frame to set the canvas background color. If the scene is transparent PixiJS will use clearRect
        /// to clear the canvas every frame. Disable this by setting this to false. For example, if
        /// your game has a canvas filling background image you often don't need this set.
        abstract clearBeforeRender: bool with get, set
        /// The background color as a number.
        abstract _backgroundColor: float with get, set
        /// The background color as an [R, G, B] array.
        abstract _backgroundColorRgba: ResizeArray<float> with get, set
        /// The background color as a string.
        abstract _backgroundColorString: string with get, set
        /// This temporary display object used as the parent of the currently being rendered item.
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// The last root object that the renderer tried to render.
        abstract _lastObjectRendered: PIXI.DisplayObject with get, set
        /// Collection of plugins.
        abstract plugins: obj option
        /// <summary>Initialize the plugins.</summary>
        /// <param name="staticMap">- The dictionary of statically saved plugins.</param>
        abstract initPlugins: staticMap: obj option -> unit
        /// Same as view.width, actual number of pixels in the canvas by horizontal.
        abstract width: float
        /// Same as view.height, actual number of pixels in the canvas by vertical.
        abstract height: float
        /// <summary>Resizes the screen and canvas to the specified width and height.
        /// Canvas dimensions are multiplied by resolution.</summary>
        /// <param name="screenWidth">- The new width of the screen.</param>
        /// <param name="screenHeight">- The new height of the screen.</param>
        abstract resize: screenWidth: float * screenHeight: float -> unit
        /// <summary>Useful function that returns a texture of the display object that can then be used to create sprites
        /// This can be quite useful if your displayObject is complicated and needs to be reused multiple times.</summary>
        /// <param name="displayObject">- The displayObject the object will be generated from.</param>
        /// <param name="scaleMode">- Should be one of the scaleMode consts.</param>
        /// <param name="resolution">- The resolution / device pixel ratio of the texture being generated.</param>
        /// <param name="region">- The region of the displayObject, that shall be rendered,
        /// if no region is specified, defaults to the local bounds of the displayObject.</param>
        abstract generateTexture: displayObject: PIXI.DisplayObject * scaleMode: float * resolution: float * ?region: PIXI.Rectangle -> PIXI.Texture
        /// <summary>Removes everything from the renderer and optionally removes the Canvas DOM element.</summary>
        /// <param name="removeView">- Removes the Canvas element from the DOM.</param>
        abstract destroy: ?removeView: bool -> unit
        /// The background color to fill if not transparent
        abstract backgroundColor: float with get, set

    /// The AbstractRenderer is the base for a PixiJS Renderer. It is extended by the {@link PIXI.CanvasRenderer}
    /// and {@link PIXI.Renderer} which can be used for rendering a PixiJS scene.
    type [<AllowNullLiteral>] AbstractRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: system: string * ?options: AbstractRendererStaticOptions -> AbstractRenderer

    type [<AllowNullLiteral>] AbstractRendererStaticOptions =
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract view: Browser.Types.HTMLCanvasElement option with get, set
        abstract transparent: bool option with get, set
        abstract autoDensity: bool option with get, set
        abstract antialias: bool option with get, set
        abstract resolution: float option with get, set
        abstract preserveDrawingBuffer: bool option with get, set
        abstract clearBeforeRender: bool option with get, set
        abstract backgroundColor: float option with get, set

    /// Used by the BatchRenderer
    type [<AllowNullLiteral>] BatchBuffer =
        /// View on the vertices as a float [] for positions
        abstract float32View: float [] with get, set
        /// View on the vertices as a Uint32Array for uvs
        abstract uint32View: float [] with get, set
        /// Destroys the buffer.
        abstract destroy: unit -> unit

    /// Used by the BatchRenderer
    type [<AllowNullLiteral>] BatchBufferStatic =
        [<Emit "new $0($1...)">] abstract Create: size: float -> BatchBuffer

    /// Used by the batcher to draw batches.
    /// Each one of these contains all information required to draw a bound geometry.
    type [<AllowNullLiteral>] BatchDrawCall =
        interface end

    /// Used by the batcher to draw batches.
    /// Each one of these contains all information required to draw a bound geometry.
    type [<AllowNullLiteral>] BatchDrawCallStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BatchDrawCall

    /// Geometry used to batch standard PIXI content (e.g. Mesh, Sprite, Graphics objects).
    type [<AllowNullLiteral>] BatchGeometry =
        /// Buffer used for position, color, texture IDs
        abstract _buffer: PIXI.Buffer with get, set
        /// Index buffer data
        abstract _indexBuffer: PIXI.Buffer with get, set

    /// Geometry used to batch standard PIXI content (e.g. Mesh, Sprite, Graphics objects).
    type [<AllowNullLiteral>] BatchGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?_static: bool -> BatchGeometry

    type [<AllowNullLiteral>] BatchPluginFactory =
        interface end

    type [<AllowNullLiteral>] BatchPluginFactoryStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BatchPluginFactory
        /// <summary>Create a new BatchRenderer plugin for Renderer. this convenience can provide an easy way
        /// to extend BatchRenderer with all the necessary pieces.</summary>
        /// <param name="options"></param>
        abstract create: ?options: BatchPluginFactoryStaticCreateOptions -> PIXI.BatchRenderer
        /// The default vertex shader source
        abstract defaultVertexSrc: string
        /// The default fragment shader source
        abstract defaultFragmentTemplate: string

    type [<AllowNullLiteral>] BatchPluginFactoryStaticCreateOptions =
        abstract vertex: string option with get, set
        abstract fragment: string option with get, set
        abstract vertexSize: float option with get, set
        abstract geometryClass: obj option with get, set

    /// Renderer dedicated to drawing and batching sprites.
    type [<AllowNullLiteral>] BatchRenderer =
        inherit PIXI.ObjectRenderer
        /// The number of images in the SpriteRenderer before it flushes.
        abstract size: float with get, set
        /// Holds the defualt indices of the geometry (quads) to draw
        abstract onlySprites: int [] with get, set
        /// The default shaders that is used if a sprite doesn't have a more specific one.
        /// there is a shader for each number of textures that can be rendered.
        /// These shaders will also be generated on the fly as required.
        abstract shader: PIXI.Shader with get, set
        /// MultiTexture shader generator.
        abstract shaderGenerator: PIXI.BatchShaderGenerator with get, set
        /// The class we use to create geometries.
        /// Please override it in constructor
        abstract geometryClass: obj option with get, set
        /// Sets up the renderer context and necessary buffers.
        abstract contextChange: unit -> unit
        /// Called before the renderer starts rendering.
        abstract onPrerender: unit -> unit
        /// <summary>Renders the sprite object.</summary>
        /// <param name="sprite">- the sprite to render when using this spritebatch</param>
        abstract render: sprite: PIXI.Sprite -> unit
        /// Renders the content and empties the current batch.
        abstract flush: unit -> unit
        /// Starts a new sprite batch.
        abstract start: unit -> unit
        /// Stops and flushes the current batch.
        abstract stop: unit -> unit
        /// Destroys the SpriteRenderer.
        abstract destroy: unit -> unit
        /// The renderer this manager works for.
        abstract renderer: PIXI.Renderer with get, set

    /// Renderer dedicated to drawing and batching sprites.
    type [<AllowNullLiteral>] BatchRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> BatchRenderer

    /// Helper that generates batching multi-texture shader. Use it with your new BatchRenderer
    type [<AllowNullLiteral>] BatchShaderGenerator =
        /// Reference to the vertex shader source.
        abstract vertexSrc: string with get, set
        /// Reference to the fragement shader template. Must contain "%count%" and "%forloop%".
        abstract fragTemplate: string with get, set

    /// Helper that generates batching multi-texture shader. Use it with your new BatchRenderer
    type [<AllowNullLiteral>] BatchShaderGeneratorStatic =
        [<Emit "new $0($1...)">] abstract Create: vertexSrc: string * fragTemplate: string -> BatchShaderGenerator

    /// Base for a common object renderer that can be used as a system renderer plugin.
    type [<AllowNullLiteral>] ObjectRenderer =
        inherit PIXI.System
        /// Starts the renderer and sets the shader
        abstract start: unit -> unit
        /// Stops the renderer
        abstract stop: unit -> unit
        /// Stub method for rendering content and emptying the current batch.
        abstract flush: unit -> unit
        /// <summary>Renders an object</summary>
        /// <param name="object">- The object to render.</param>
        abstract render: ``object``: PIXI.DisplayObject -> unit
        /// The renderer this manager works for.
        abstract renderer: PIXI.Renderer with get, set
        /// <summary>Generic method called when there is a WebGL context change.</summary>
        /// <param name="gl">new webgl context</param>
        // TODO abstract contextChange: gl: WebGLRenderingContext -> unit
        /// Generic destroy methods to be overridden by the subclass
        abstract destroy: unit -> unit

    /// Base for a common object renderer that can be used as a system renderer plugin.
    type [<AllowNullLiteral>] ObjectRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ObjectRenderer

    /// Filter is a special type of WebGL shader that is applied to the screen.
    /// 
    /// {@link http://pixijs.io/examples/#/filters/blur-filter.js Example} of the
    /// {@link PIXI.filters.BlurFilter BlurFilter}.
    /// 
    /// ### Usage
    /// Filters can be applied to any DisplayObject or Container.
    /// PixiJS' `FilterSystem` renders the container into temporary Framebuffer,
    /// then filter renders it to the screen.
    /// Multiple filters can be added to the `filters` array property and stacked on each other.
    /// 
    /// ```
    /// const filter = new PIXI.Filter(myShaderVert, myShaderFrag, { myUniform: 0.5 });
    /// const container = new PIXI.Container();
    /// container.filters = [filter];
    /// ```
    /// 
    /// ### Previous Version Differences
    /// 
    /// In PixiJS **v3**, a filter was always applied to _whole screen_.
    /// 
    /// In PixiJS **v4**, a filter can be applied _only part of the screen_.
    /// Developers had to create a set of uniforms to deal with coordinates.
    /// 
    /// In PixiJS **v5** combines _both approaches_.
    /// Developers can use normal coordinates of v3 and then allow filter to use partial Framebuffers,
    /// bringing those extra uniforms into account.
    /// 
    /// Also be aware that we have changed default vertex shader, please consult
    /// {@link https://github.com/pixijs/pixi.js/wiki/v5-Creating-filters Wiki}.
    /// 
    /// ### Built-in Uniforms
    /// 
    /// PixiJS viewport uses screen (CSS) coordinates, `(0, 0, renderer.screen.width, renderer.screen.height)`,
    /// and `projectionMatrix` uniform maps it to the gl viewport.
    /// 
    /// **uSampler**
    /// 
    /// The most important uniform is the input texture that container was rendered into.
    /// _Important note: as with all Framebuffers in PixiJS, both input and output are
    /// premultiplied by alpha._
    /// 
    /// By default, input normalized coordinates are passed to fragment shader with `vTextureCoord`.
    /// Use it to sample the input.
    /// 
    /// ```
    /// const fragment = `
    /// varying vec2 vTextureCoord;
    /// uniform sampler2D uSampler;
    /// void main(void)
    /// {
    ///     gl_FragColor = texture2D(uSampler, vTextureCoord);
    /// }
    /// `;
    /// 
    /// const myFilter = new PIXI.Filter(null, fragment);
    /// ```
    /// 
    /// This filter is just one uniform less than {@link PIXI.filters.AlphaFilter AlphaFilter}.
    /// 
    /// **outputFrame**
    /// 
    /// The `outputFrame` holds the rectangle where filter is applied in screen (CSS) coordinates.
    /// It's the same as `renderer.screen` for a fullscreen filter.
    /// Only a part of  `outputFrame.zw` size of temporary Framebuffer is used,
    /// `(0, 0, outputFrame.width, outputFrame.height)`,
    /// 
    /// Filters uses this quad to normalized (0-1) space, its passed into `aVertexPosition` attribute.
    /// To calculate vertex position in screen space using normalized (0-1) space:
    /// 
    /// ```
    /// vec4 filterVertexPosition( void )
    /// {
    ///      vec2 position = aVertexPosition * max(outputFrame.zw, vec2(0.)) + outputFrame.xy;
    ///      return vec4((projectionMatrix * vec3(position, 1.0)).xy, 0.0, 1.0);
    /// }
    /// ```
    /// 
    /// **inputSize**
    /// 
    /// Temporary framebuffer is different, it can be either the size of screen, either power-of-two.
    /// The `inputSize.xy` are size of temporary framebuffer that holds input.
    /// The `inputSize.zw` is inverted, it's a shortcut to evade division inside the shader.
    /// 
    /// Set `inputSize.xy = outputFrame.zw` for a fullscreen filter.
    /// 
    /// To calculate input normalized coordinate, you have to map it to filter normalized space.
    /// Multiply by `outputFrame.zw` to get input coordinate.
    /// Divide by `inputSize.xy` to get input normalized coordinate.
    /// 
    /// ```
    /// vec2 filterTextureCoord( void )
    /// {
    ///      return aVertexPosition * (outputFrame.zw * inputSize.zw); // same as /inputSize.xy
    /// }
    /// ```
    /// **resolution**
    /// 
    /// The `resolution` is the ratio of screen (CSS) pixels to real pixels.
    /// 
    /// **inputPixel**
    /// 
    /// `inputPixel.xy` is the size of framebuffer in real pixels, same as `inputSize.xy * resolution`
    /// `inputPixel.zw` is inverted `inputPixel.xy`.
    /// 
    /// It's handy for filters that use neighbour pixels, like {@link PIXI.filters.FXAAFilter FXAAFilter}.
    /// 
    /// **inputClamp**
    /// 
    /// If you try to get info from outside of used part of Framebuffer - you'll get undefined behaviour.
    /// For displacements, coordinates has to be clamped.
    /// 
    /// The `inputClamp.xy` is left-top pixel center, you may ignore it, because we use left-top part of Framebuffer
    /// `inputClamp.zw` is bottom-right pixel center.
    /// 
    /// ```
    /// vec4 color = texture2D(uSampler, clamp(modifigedTextureCoord, inputClamp.xy, inputClamp.zw))
    /// ```
    /// OR
    /// ```
    /// vec4 color = texture2D(uSampler, min(modifigedTextureCoord, inputClamp.zw))
    /// ```
    /// 
    /// ### Additional Information
    /// 
    /// Complete documentation on Filter usage is located in the
    /// {@link https://github.com/pixijs/pixi.js/wiki/v5-Creating-filters Wiki}.
    /// 
    /// Since PixiJS only had a handful of built-in filters, additional filters can be downloaded
    /// {@link https://github.com/pixijs/pixi-filters here} from the PixiJS Filters repository.
    type [<AllowNullLiteral>] Filter =
        inherit PIXI.Shader
        /// The padding of the filter. Some filters require extra space to breath such as a blur.
        /// Increasing this will add extra width and height to the bounds of the object that the
        /// filter is applied to.
        abstract padding: float with get, set
        /// The resolution of the filter. Setting this to be lower will lower the quality but
        /// increase the performance of the filter.
        abstract resolution: float with get, set
        /// If enabled is true the filter is applied, if false it will not.
        abstract enabled: bool with get, set
        /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
        /// Switch it off if it does not work for specific shader.
        abstract autoFit: bool with get, set
        /// Legacy filters use position and uvs from attributes
        abstract legacy: bool
        /// The WebGL state the filter requires to render
        abstract state: PIXI.State with get, set
        /// <summary>Applies the filter</summary>
        /// <param name="filterManager">- The renderer to retrieve the filter from</param>
        /// <param name="input">- The input render target.</param>
        /// <param name="output">- The target to output to.</param>
        /// <param name="clear">- Should the output be cleared before rendering to it</param>
        /// <param name="currentState">- It's current state of filter.
        /// There are some useful properties in the currentState :
        /// target, filters, sourceFrame, destinationFrame, renderTarget, resolution</param>
        abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool * ?currentState: obj -> unit
        /// Sets the blendmode of the filter
        abstract blendMode: float with get, set
        /// Shader uniform values, shortcut for `uniformGroup.uniforms`
        abstract uniforms: obj option

    /// Filter is a special type of WebGL shader that is applied to the screen.
    /// 
    /// {@link http://pixijs.io/examples/#/filters/blur-filter.js Example} of the
    /// {@link PIXI.filters.BlurFilter BlurFilter}.
    /// 
    /// ### Usage
    /// Filters can be applied to any DisplayObject or Container.
    /// PixiJS' `FilterSystem` renders the container into temporary Framebuffer,
    /// then filter renders it to the screen.
    /// Multiple filters can be added to the `filters` array property and stacked on each other.
    /// 
    /// ```
    /// const filter = new PIXI.Filter(myShaderVert, myShaderFrag, { myUniform: 0.5 });
    /// const container = new PIXI.Container();
    /// container.filters = [filter];
    /// ```
    /// 
    /// ### Previous Version Differences
    /// 
    /// In PixiJS **v3**, a filter was always applied to _whole screen_.
    /// 
    /// In PixiJS **v4**, a filter can be applied _only part of the screen_.
    /// Developers had to create a set of uniforms to deal with coordinates.
    /// 
    /// In PixiJS **v5** combines _both approaches_.
    /// Developers can use normal coordinates of v3 and then allow filter to use partial Framebuffers,
    /// bringing those extra uniforms into account.
    /// 
    /// Also be aware that we have changed default vertex shader, please consult
    /// {@link https://github.com/pixijs/pixi.js/wiki/v5-Creating-filters Wiki}.
    /// 
    /// ### Built-in Uniforms
    /// 
    /// PixiJS viewport uses screen (CSS) coordinates, `(0, 0, renderer.screen.width, renderer.screen.height)`,
    /// and `projectionMatrix` uniform maps it to the gl viewport.
    /// 
    /// **uSampler**
    /// 
    /// The most important uniform is the input texture that container was rendered into.
    /// _Important note: as with all Framebuffers in PixiJS, both input and output are
    /// premultiplied by alpha._
    /// 
    /// By default, input normalized coordinates are passed to fragment shader with `vTextureCoord`.
    /// Use it to sample the input.
    /// 
    /// ```
    /// const fragment = `
    /// varying vec2 vTextureCoord;
    /// uniform sampler2D uSampler;
    /// void main(void)
    /// {
    ///     gl_FragColor = texture2D(uSampler, vTextureCoord);
    /// }
    /// `;
    /// 
    /// const myFilter = new PIXI.Filter(null, fragment);
    /// ```
    /// 
    /// This filter is just one uniform less than {@link PIXI.filters.AlphaFilter AlphaFilter}.
    /// 
    /// **outputFrame**
    /// 
    /// The `outputFrame` holds the rectangle where filter is applied in screen (CSS) coordinates.
    /// It's the same as `renderer.screen` for a fullscreen filter.
    /// Only a part of  `outputFrame.zw` size of temporary Framebuffer is used,
    /// `(0, 0, outputFrame.width, outputFrame.height)`,
    /// 
    /// Filters uses this quad to normalized (0-1) space, its passed into `aVertexPosition` attribute.
    /// To calculate vertex position in screen space using normalized (0-1) space:
    /// 
    /// ```
    /// vec4 filterVertexPosition( void )
    /// {
    ///      vec2 position = aVertexPosition * max(outputFrame.zw, vec2(0.)) + outputFrame.xy;
    ///      return vec4((projectionMatrix * vec3(position, 1.0)).xy, 0.0, 1.0);
    /// }
    /// ```
    /// 
    /// **inputSize**
    /// 
    /// Temporary framebuffer is different, it can be either the size of screen, either power-of-two.
    /// The `inputSize.xy` are size of temporary framebuffer that holds input.
    /// The `inputSize.zw` is inverted, it's a shortcut to evade division inside the shader.
    /// 
    /// Set `inputSize.xy = outputFrame.zw` for a fullscreen filter.
    /// 
    /// To calculate input normalized coordinate, you have to map it to filter normalized space.
    /// Multiply by `outputFrame.zw` to get input coordinate.
    /// Divide by `inputSize.xy` to get input normalized coordinate.
    /// 
    /// ```
    /// vec2 filterTextureCoord( void )
    /// {
    ///      return aVertexPosition * (outputFrame.zw * inputSize.zw); // same as /inputSize.xy
    /// }
    /// ```
    /// **resolution**
    /// 
    /// The `resolution` is the ratio of screen (CSS) pixels to real pixels.
    /// 
    /// **inputPixel**
    /// 
    /// `inputPixel.xy` is the size of framebuffer in real pixels, same as `inputSize.xy * resolution`
    /// `inputPixel.zw` is inverted `inputPixel.xy`.
    /// 
    /// It's handy for filters that use neighbour pixels, like {@link PIXI.filters.FXAAFilter FXAAFilter}.
    /// 
    /// **inputClamp**
    /// 
    /// If you try to get info from outside of used part of Framebuffer - you'll get undefined behaviour.
    /// For displacements, coordinates has to be clamped.
    /// 
    /// The `inputClamp.xy` is left-top pixel center, you may ignore it, because we use left-top part of Framebuffer
    /// `inputClamp.zw` is bottom-right pixel center.
    /// 
    /// ```
    /// vec4 color = texture2D(uSampler, clamp(modifigedTextureCoord, inputClamp.xy, inputClamp.zw))
    /// ```
    /// OR
    /// ```
    /// vec4 color = texture2D(uSampler, min(modifigedTextureCoord, inputClamp.zw))
    /// ```
    /// 
    /// ### Additional Information
    /// 
    /// Complete documentation on Filter usage is located in the
    /// {@link https://github.com/pixijs/pixi.js/wiki/v5-Creating-filters Wiki}.
    /// 
    /// Since PixiJS only had a handful of built-in filters, additional filters can be downloaded
    /// {@link https://github.com/pixijs/pixi-filters here} from the PixiJS Filters repository.
    type [<AllowNullLiteral>] FilterStatic =
        [<Emit "new $0($1...)">] abstract Create: ?vertexSrc: string * ?fragmentSrc: string * ?uniforms: obj -> Filter
        /// The default vertex shader source
        abstract defaultVertexSrc: string
        /// The default fragment shader source
        abstract defaultFragmentSrc: string
        /// Used for caching shader IDs
        abstract SOURCE_KEY_MAP: obj option with get, set

    /// This handles a Sprite acting as a mask, as opposed to a Graphic.
    /// 
    /// WebGL only.
    type [<AllowNullLiteral>] SpriteMaskFilter =
        inherit PIXI.Filter
        /// Sprite mask
        abstract maskSprite: PIXI.Sprite with get, set
        /// Mask matrix
        abstract maskMatrix: PIXI.Matrix with get, set
        /// <summary>Applies the filter</summary>
        /// <param name="filterManager">- The renderer to retrieve the filter from</param>
        /// <param name="input">- The input render target.</param>
        /// <param name="output">- The target to output to.</param>
        /// <param name="clear">- Should the output be cleared before rendering to it.</param>
        abstract apply: filterManager: PIXI.Systems.FilterSystem * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool -> unit
        /// The padding of the filter. Some filters require extra space to breath such as a blur.
        /// Increasing this will add extra width and height to the bounds of the object that the
        /// filter is applied to.
        abstract padding: float with get, set
        /// The resolution of the filter. Setting this to be lower will lower the quality but
        /// increase the performance of the filter.
        abstract resolution: float with get, set
        /// If enabled is true the filter is applied, if false it will not.
        abstract enabled: bool with get, set
        /// If enabled, PixiJS will fit the filter area into boundaries for better performance.
        /// Switch it off if it does not work for specific shader.
        abstract autoFit: bool with get, set
        /// Legacy filters use position and uvs from attributes
        abstract legacy: bool
        /// The WebGL state the filter requires to render
        abstract state: PIXI.State with get, set
        /// Sets the blendmode of the filter
        abstract blendMode: float with get, set
        /// Shader uniform values, shortcut for `uniformGroup.uniforms`
        abstract uniforms: obj option

    /// This handles a Sprite acting as a mask, as opposed to a Graphic.
    /// 
    /// WebGL only.
    type [<AllowNullLiteral>] SpriteMaskFilterStatic =
        [<Emit "new $0($1...)">] abstract Create: sprite: PIXI.Sprite -> SpriteMaskFilter

    type WebGLRenderingContext = obj

    /// Frame buffer used by the BaseRenderTexture
    type [<AllowNullLiteral>] Framebuffer =
        /// Reference to the colorTexture.
        abstract colorTexture: ResizeArray<PIXI.Texture>
        /// <summary>Add texture to the colorTexture array</summary>
        /// <param name="index">- Index of the array to add the texture to</param>
        /// <param name="texture">- Texture to add to the array</param>
        abstract addColorTexture: ?index: float * ?texture: PIXI.Texture -> unit
        /// <summary>Add a depth texture to the frame buffer</summary>
        /// <param name="texture">- Texture to add</param>
        abstract addDepthTexture: ?texture: PIXI.Texture -> unit
        /// Enable depth on the frame buffer
        abstract enableDepth: unit -> unit
        /// Enable stencil on the frame buffer
        abstract enableStencil: unit -> unit
        /// <summary>Resize the frame buffer</summary>
        /// <param name="width">- Width of the frame buffer to resize to</param>
        /// <param name="height">- Height of the frame buffer to resize to</param>
        abstract resize: width: float * height: float -> unit
        /// disposes WebGL resources that are connected to this geometry
        abstract dispose: unit -> unit

    /// Frame buffer used by the BaseRenderTexture
    type [<AllowNullLiteral>] FramebufferStatic =
        [<Emit "new $0($1...)">] abstract Create: width: float * height: float -> Framebuffer

    /// Holds the information for a single attribute structure required to render geometry.
    /// 
    /// This does not contain the actual data, but instead has a buffer id that maps to a {@link PIXI.Buffer}
    /// This can include anything from positions, uvs, normals, colors etc.
    type [<AllowNullLiteral>] Attribute =
        /// Destroys the Attribute.
        abstract destroy: unit -> unit

    /// Holds the information for a single attribute structure required to render geometry.
    /// 
    /// This does not contain the actual data, but instead has a buffer id that maps to a {@link PIXI.Buffer}
    /// This can include anything from positions, uvs, normals, colors etc.
    type [<AllowNullLiteral>] AttributeStatic =
        [<Emit "new $0($1...)">] abstract Create: buffer: string * ?size: float * ?normalized: bool * ?``type``: float * ?stride: float * ?start: float -> Attribute
        /// <summary>Helper function that creates an Attribute based on the information provided</summary>
        /// <param name="buffer">the id of the buffer that this attribute will look for</param>
        /// <param name="size">the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2</param>
        /// <param name="stride">How far apart (in floats) the start of each value is. (used for interleaving data)</param>
        /// <param name="start">How far into the array to start reading values (used for interleaving data)</param>
        /// <param name="normalized">should the data be normalized.</param>
        abstract from: buffer: string * ?size: float * ?stride: float * ?start: float * ?normalized: bool -> PIXI.Attribute

    /// A wrapper for data so that it can be used and uploaded by WebGL
    type [<AllowNullLiteral>] Buffer =
        /// The data in the buffer, as a typed array
        //abstract data: U3<ArrayBuffer, SharedArrayBuffer, ArrayBufferView> with get, set
        abstract data: byte [] 
        /// <summary>flags this buffer as requiring an upload to the GPU</summary>
        /// <param name="data">the data to update in the buffer.</param>
        abstract update: ?data: byte [] -> unit
        /// disposes WebGL resources that are connected to this geometry
        abstract dispose: unit -> unit
        /// Destroys the buffer
        abstract destroy: unit -> unit

    /// A wrapper for data so that it can be used and uploaded by WebGL
    type [<AllowNullLiteral>] BufferStatic =
//        [<Emit "new $0($1...)">] abstract Create: data: U3<ArrayBuffer, SharedArrayBuffer, ArrayBufferView> * ?_static: bool * ?index: bool -> Buffer
        [<Emit "new $0($1...)">] abstract Create: data: byte [] * ?_static: bool * ?index: bool -> Buffer
        /// <summary>Helper function that creates a buffer based on an array or TypedArray</summary>
        /// <param name="data">the TypedArray that the buffer will store. If this is a regular Array it will be converted to a float [].</param>
        abstract from: data: ResizeArray<float> -> PIXI.Buffer
//        abstract from: data: U2<ArrayBufferView, ResizeArray<float>> -> PIXI.Buffer

    /// The Geometry represents a model. It consists of two components:
    /// - GeometryStyle - The structure of the model such as the attributes layout
    /// - GeometryData - the data of the model - this consists of buffers.
    /// This can include anything from positions, uvs, normals, colors etc.
    /// 
    /// Geometry can be defined without passing in a style or data if required (thats how I prefer!)
    /// 
    /// ```js
    /// let geometry = new PIXI.Geometry();
    /// 
    /// geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
    /// geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1],2)
    /// geometry.addIndex([0,1,2,1,3,2])
    /// 
    /// ```
    type [<AllowNullLiteral>] Geometry =
        /// A map of renderer IDs to webgl VAOs
        abstract glVertexArrayObjects: obj option with get, set
        /// Count of existing (not destroyed) meshes that reference this geometry
        abstract refCount: float with get, set
        /// <summary>Adds an attribute to the geometry</summary>
        /// <param name="id">- the name of the attribute (matching up to a shader)</param>
        /// <param name="buffer">the buffer that holds the data of the attribute . You can also provide an Array and a buffer will be created from it.</param>
        /// <param name="size">the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2</param>
        /// <param name="normalized">should the data be normalized.</param>
        /// <param name="type">what type of number is the attribute. Check {PIXI.TYPES} to see the ones available</param>
        /// <param name="stride">How far apart (in floats) the start of each value is. (used for interleaving data)</param>
        /// <param name="start">How far into the array to start reading values (used for interleaving data)</param>
        abstract addAttribute: id: string * ?buffer: PIXI.Buffer * ?size: float * ?normalized: bool * ?``type``: float * ?stride: float * ?start: float -> PIXI.Geometry
        /// <summary>returns the requested attribute</summary>
        /// <param name="id">the name of the attribute required</param>
        abstract getAttribute: id: string -> PIXI.Attribute
        /// <summary>returns the requested buffer</summary>
        /// <param name="id">the name of the buffer required</param>
        abstract getBuffer: id: string -> PIXI.Buffer
        /// <summary>Adds an index buffer to the geometry
        /// The index buffer contains integers, three for each triangle in the geometry, which reference the various attribute buffers (position, colour, UV coordinates, other UV coordinates, normal, …). There is only ONE index buffer.</summary>
        /// <param name="buffer">the buffer that holds the data of the index buffer. You can also provide an Array and a buffer will be created from it.</param>
        abstract addIndex: ?buffer: PIXI.Buffer -> PIXI.Geometry
        /// returns the index buffer
        abstract getIndex: unit -> PIXI.Buffer
        /// this function modifies the structure so that all current attributes become interleaved into a single buffer
        /// This can be useful if your model remains static as it offers a little performance boost
        abstract interleave: unit -> PIXI.Geometry
        /// disposes WebGL resources that are connected to this geometry
        abstract dispose: unit -> unit
        /// Destroys the geometry.
        abstract destroy: unit -> unit
        /// returns a clone of the geometry
        abstract clone: unit -> PIXI.Geometry

    /// The Geometry represents a model. It consists of two components:
    /// - GeometryStyle - The structure of the model such as the attributes layout
    /// - GeometryData - the data of the model - this consists of buffers.
    /// This can include anything from positions, uvs, normals, colors etc.
    /// 
    /// Geometry can be defined without passing in a style or data if required (thats how I prefer!)
    /// 
    /// ```js
    /// let geometry = new PIXI.Geometry();
    /// 
    /// geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
    /// geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1],2)
    /// geometry.addIndex([0,1,2,1,3,2])
    /// 
    /// ```
    type [<AllowNullLiteral>] GeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?buffers: ResizeArray<PIXI.Buffer> * ?attributes: obj -> Geometry
        /// <summary>merges an array of geometries into a new single one
        /// geometry attribute styles must match for this operation to work</summary>
        /// <param name="geometries">array of geometries to merge</param>
        abstract merge: geometries: ResizeArray<PIXI.Geometry> -> PIXI.Geometry

    /// The Renderer draws the scene and all its content onto a WebGL enabled canvas.
    /// 
    /// This renderer should be used for browsers that support WebGL.
    /// 
    /// This renderer works by automatically managing WebGLBatchesm, so no need for Sprite Batches or Sprite Clouds.
    /// Don't forget to add the view to your DOM or you will not see anything!
    type [<AllowNullLiteral>] Renderer =
        inherit PIXI.AbstractRenderer
        /// The type of this renderer as a standardized const
        abstract ``type``: float with get, set
        /// Global uniforms
        abstract globalUniforms: PIXI.UniformGroup with get, set
        /// Mask system instance
        abstract mask: PIXI.Systems.MaskSystem
        /// Context system instance
        abstract context: PIXI.Systems.ContextSystem
        /// State system instance
        abstract state: PIXI.Systems.StateSystem
        /// Shader system instance
        abstract shader: PIXI.Systems.ShaderSystem
        /// Texture system instance
        abstract texture: PIXI.Systems.TextureSystem
        /// Geometry system instance
        abstract geometry: PIXI.Systems.GeometrySystem
        /// Framebuffer system instance
        abstract framebuffer: PIXI.Systems.FramebufferSystem
        /// Stencil system instance
        abstract stencil: PIXI.Systems.StencilSystem
        /// Projection system instance
        abstract projection: PIXI.Systems.ProjectionSystem
        /// Texture garbage collector system instance
        abstract textureGC: PIXI.Systems.TextureGCSystem
        /// Filter system instance
        abstract filter: PIXI.Systems.FilterSystem
        /// RenderTexture system instance
        abstract renderTexture: PIXI.Systems.RenderTextureSystem
        /// Batch system instance
        abstract batch: PIXI.Systems.BatchSystem
        /// Flag if we are rendering to the screen vs renderTexture
        abstract renderingToScreen: bool
        /// <summary>Add a new system to the renderer.</summary>
        /// <param name="ClassRef">- Class reference</param>
        /// <param name="name">- Property name for system, if not specified
        /// will use a static `name` property on the class itself. This
        /// name will be assigned as s property on the Renderer so make
        /// sure it doesn't collide with properties on Renderer.</param>
        abstract addSystem: ClassRef: (ResizeArray<obj option> -> obj option) * ?name: string -> PIXI.Renderer
        /// <summary>Renders the object to its WebGL view</summary>
        /// <param name="displayObject">- The object to be rendered.</param>
        /// <param name="renderTexture">- The render texture to render to.</param>
        /// <param name="clear">- Should the canvas be cleared before the new render.</param>
        /// <param name="transform">- A transform to apply to the render texture before rendering.</param>
        /// <param name="skipUpdateTransform">- Should we skip the update transform pass?</param>
        abstract render: displayObject: PIXI.DisplayObject * ?renderTexture: PIXI.RenderTexture * ?clear: bool * ?transform: PIXI.Matrix * ?skipUpdateTransform: bool -> unit
        /// <summary>Resizes the WebGL view to the specified width and height.</summary>
        /// <param name="screenWidth">- The new width of the screen.</param>
        /// <param name="screenHeight">- The new height of the screen.</param>
        abstract resize: screenWidth: float * screenHeight: float -> unit
        /// Resets the WebGL state so you can render things however you fancy!
        abstract reset: unit -> PIXI.Renderer
        /// Clear the frame buffer
        abstract clear: unit -> unit
        /// <summary>Removes everything from the renderer (event listeners, spritebatch, etc...)</summary>
        /// <param name="removeView">- Removes the Canvas element from the DOM.
        /// See: https://github.com/pixijs/pixi.js/issues/2233</param>
        abstract destroy: ?removeView: bool -> unit
        /// Collection of installed plugins. These are included by default in PIXI, but can be excluded
        /// by creating a custom build. Consult the README for more information about creating custom
        /// builds and excluding plugins.
        abstract plugins: TypeLiteral_12
        /// Collection of methods for extracting data (image, pixels, etc.) from a display object or render texture
        abstract extract: PIXI.Extract.Extract with get, set
        abstract autoResize: bool with get, set
        /// The supplied constructor options.
        abstract options: obj option
        /// Measurements of the screen. (0, 0, screenWidth, screenHeight).
        /// 
        /// Its safe to use as filterArea or hitArea for the whole stage.
        abstract screen: PIXI.Rectangle with get, set
        /// The canvas element that everything is drawn to.
        abstract view: Browser.Types.HTMLCanvasElement with get, set
        /// The resolution / device pixel ratio of the renderer.
        abstract resolution: float with get, set
        /// Whether the render view is transparent.
        abstract transparent: bool with get, set
        /// Whether CSS dimensions of canvas view should be resized to screen dimensions automatically.
        abstract autoDensity: bool with get, set
        /// The value of the preserveDrawingBuffer flag affects whether or not the contents of
        /// the stencil buffer is retained after rendering.
        abstract preserveDrawingBuffer: bool with get, set
        /// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
        /// If the scene is NOT transparent PixiJS will use a canvas sized fillRect operation every
        /// frame to set the canvas background color. If the scene is transparent PixiJS will use clearRect
        /// to clear the canvas every frame. Disable this by setting this to false. For example, if
        /// your game has a canvas filling background image you often don't need this set.
        abstract clearBeforeRender: bool with get, set
        /// The background color as a number.
        abstract _backgroundColor: float with get, set
        /// The background color as an [R, G, B] array.
        abstract _backgroundColorRgba: ResizeArray<float> with get, set
        /// The background color as a string.
        abstract _backgroundColorString: string with get, set
        /// This temporary display object used as the parent of the currently being rendered item.
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// The last root object that the renderer tried to render.
        abstract _lastObjectRendered: PIXI.DisplayObject with get, set
        /// <summary>Initialize the plugins.</summary>
        /// <param name="staticMap">- The dictionary of statically saved plugins.</param>
        abstract initPlugins: staticMap: obj option -> unit
        /// Same as view.width, actual number of pixels in the canvas by horizontal.
        abstract width: float
        /// Same as view.height, actual number of pixels in the canvas by vertical.
        abstract height: float
        /// <summary>Useful function that returns a texture of the display object that can then be used to create sprites
        /// This can be quite useful if your displayObject is complicated and needs to be reused multiple times.</summary>
        /// <param name="displayObject">- The displayObject the object will be generated from.</param>
        /// <param name="scaleMode">- Should be one of the scaleMode consts.</param>
        /// <param name="resolution">- The resolution / device pixel ratio of the texture being generated.</param>
        /// <param name="region">- The region of the displayObject, that shall be rendered,
        /// if no region is specified, defaults to the local bounds of the displayObject.</param>
        abstract generateTexture: displayObject: PIXI.DisplayObject * scaleMode: float * resolution: float * ?region: PIXI.Rectangle -> PIXI.Texture
        /// The background color to fill if not transparent
        abstract backgroundColor: float with get, set

    /// The Renderer draws the scene and all its content onto a WebGL enabled canvas.
    /// 
    /// This renderer should be used for browsers that support WebGL.
    /// 
    /// This renderer works by automatically managing WebGLBatchesm, so no need for Sprite Batches or Sprite Clouds.
    /// Don't forget to add the view to your DOM or you will not see anything!
    type [<AllowNullLiteral>] RendererStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: RendererStaticOptions -> Renderer
        /// <summary>Adds a plugin to the renderer.</summary>
        /// <param name="pluginName">- The name of the plugin.</param>
        /// <param name="ctor">- The constructor function or class for the plugin.</param>
        abstract registerPlugin: pluginName: string * ctor: (ResizeArray<obj option> -> obj option) -> unit

    type [<AllowNullLiteral>] RendererStaticOptions =
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract view: Browser.Types.HTMLCanvasElement option with get, set
        abstract transparent: bool option with get, set
        abstract autoDensity: bool option with get, set
        abstract antialias: bool option with get, set
        abstract forceFXAA: bool option with get, set
        abstract resolution: float option with get, set
        abstract clearBeforeRender: bool option with get, set
        abstract preserveDrawingBuffer: bool option with get, set
        abstract backgroundColor: float option with get, set
        abstract powerPreference: string option with get, set
        abstract context: obj option with get, set

    /// A BaseRenderTexture is a special texture that allows any PixiJS display object to be rendered to it.
    /// 
    /// __Hint__: All DisplayObjects (i.e. Sprites) that render to a BaseRenderTexture should be preloaded
    /// otherwise black rectangles will be drawn instead.
    /// 
    /// A BaseRenderTexture takes a snapshot of any Display Object given to its render method. The position
    /// and rotation of the given Display Objects is ignored. For example:
    /// 
    /// ```js
    /// let renderer = PIXI.autoDetectRenderer();
    /// let baseRenderTexture = new PIXI.BaseRenderTexture({ width: 800, height: 600 });
    /// let renderTexture = new PIXI.RenderTexture(baseRenderTexture);
    /// let sprite = PIXI.Sprite.from("spinObj_01.png");
    /// 
    /// sprite.position.x = 800/2;
    /// sprite.position.y = 600/2;
    /// sprite.anchor.x = 0.5;
    /// sprite.anchor.y = 0.5;
    /// 
    /// renderer.render(sprite, renderTexture);
    /// ```
    /// 
    /// The Sprite in this case will be rendered using its local transform. To render this sprite at 0,0
    /// you can clear the transform
    /// 
    /// ```js
    /// 
    /// sprite.setTransform()
    /// 
    /// let baseRenderTexture = new PIXI.BaseRenderTexture({ width: 100, height: 100 });
    /// let renderTexture = new PIXI.RenderTexture(baseRenderTexture);
    /// 
    /// renderer.render(sprite, renderTexture);  // Renders to center of RenderTexture
    /// ```
    type [<AllowNullLiteral>] BaseRenderTexture =
        inherit PIXI.BaseTexture
        /// A reference to the canvas render target (we only need one as this can be shared across renderers)
        abstract _canvasRenderTarget: obj option with get, set
        /// The data structure for the stencil masks.
        abstract stencilMaskStack: ResizeArray<PIXI.Graphics> with get, set
        /// The data structure for the filters.
        abstract filterStack: ResizeArray<PIXI.Graphics> with get, set
        /// <summary>Resizes the BaseRenderTexture.</summary>
        /// <param name="width">- The width to resize to.</param>
        /// <param name="height">- The height to resize to.</param>
        abstract resize: width: float * height: float -> unit
        /// Frees the texture and framebuffer from WebGL memory without destroying this texture object.
        /// This means you can still use the texture later which will upload it to GPU
        /// memory again.
        abstract dispose: unit -> unit
        /// Destroys this texture.
        abstract destroy: unit -> unit
        abstract loadSource: unit -> unit
        abstract hasLoaded: bool
        abstract imageUrl: string
        abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, SVGElement>
        /// The width of the base texture set when the image has loaded
        abstract width: float
        /// The height of the base texture set when the image has loaded
        abstract height: float
        /// The resolution / device pixel ratio of the texture
        abstract resolution: float with get, set
        /// Mipmap mode of the texture, affects downscaled images
        abstract mipmap: PIXI.MIPMAP_MODES with get, set
        /// Anisotropic filtering level of texture
        abstract anisotropicLevel: float with get, set
        /// How the texture wraps
        abstract wrapMode: float with get, set
        /// The scale mode to apply when scaling this texture
        abstract scaleMode: PIXI.SCALE_MODES with get, set
        /// The pixel format of the texture
        abstract format: PIXI.FORMATS with get, set
        /// The type of resource data
        abstract ``type``: PIXI.TYPES with get, set
        /// The target type
        abstract target: PIXI.TARGETS with get, set
        /// Set to true to enable pre-multiplied alpha
        abstract premultiplyAlpha: bool with get, set
        /// Global unique identifier for this BaseTexture
        abstract uid: string with get, set
        /// Used by automatic texture Garbage Collection, stores last GC tick when it was bound
        abstract touched: float with get, set
        /// Whether or not the texture is a power of two, try to use power of two textures as much
        /// as you can
        abstract isPowerOfTwo: bool
        /// Used by TextureSystem to only update texture to the GPU when needed.
        /// Please call `update()` to increment it.
        abstract dirtyId: float
        /// Used by TextureSystem to only update texture style when needed.
        abstract dirtyStyleId: float with get, set
        /// Currently default cache ID.
        abstract cacheId: string with get, set
        /// Generally speaking means when resource is loaded.
        abstract valid: bool
        /// The collection of alternative cache ids, since some BaseTextures
        /// can have more than one ID, short name and longer full URL
        abstract textureCacheIds: ResizeArray<string>
        /// Flag if BaseTexture has been destroyed.
        abstract destroyed: bool
        /// The resource used by this BaseTexture, there can only
        /// be one resource per BaseTexture, but textures can share
        /// resources.
        abstract resource: PIXI.Resources.Resource
        /// Number of the texture batch, used by multi-texture renderers
        abstract _batchEnabled: float with get, set
        /// Pixel width of the source of this texture
        abstract realWidth: float
        /// Pixel height of the source of this texture
        abstract realHeight: float
        /// <summary>Changes style options of BaseTexture</summary>
        /// <param name="scaleMode">- Pixi scalemode</param>
        /// <param name="mipmap">- enable mipmaps</param>
        abstract setStyle: ?scaleMode: PIXI.SCALE_MODES * ?mipmap: PIXI.MIPMAP_MODES -> PIXI.BaseTexture
        /// <summary>Changes w/h/resolution. Texture becomes valid if width and height are greater than zero.</summary>
        /// <param name="width">Visual width</param>
        /// <param name="height">Visual height</param>
        /// <param name="resolution">Optionally set resolution</param>
        abstract setSize: width: float * height: float * ?resolution: float -> PIXI.BaseTexture
        /// <summary>Sets real size of baseTexture, preserves current resolution.</summary>
        /// <param name="realWidth">Full rendered width</param>
        /// <param name="realHeight">Full rendered height</param>
        /// <param name="resolution">Optionally set resolution</param>
        abstract setRealSize: realWidth: float * realHeight: float * ?resolution: float -> PIXI.BaseTexture
        /// <summary>Changes resolution</summary>
        /// <param name="resolution">res</param>
        abstract setResolution: ?resolution: float -> PIXI.BaseTexture
        /// <summary>Sets the resource if it wasn't set. Throws error if resource already present</summary>
        /// <param name="resource">- that is managing this BaseTexture</param>
        abstract setResource: resource: PIXI.Resources.Resource -> PIXI.BaseTexture
        /// Invalidates the object. Texture becomes valid if width and height are greater than zero.
        abstract update: unit -> unit

    /// A BaseRenderTexture is a special texture that allows any PixiJS display object to be rendered to it.
    /// 
    /// __Hint__: All DisplayObjects (i.e. Sprites) that render to a BaseRenderTexture should be preloaded
    /// otherwise black rectangles will be drawn instead.
    /// 
    /// A BaseRenderTexture takes a snapshot of any Display Object given to its render method. The position
    /// and rotation of the given Display Objects is ignored. For example:
    /// 
    /// ```js
    /// let renderer = PIXI.autoDetectRenderer();
    /// let baseRenderTexture = new PIXI.BaseRenderTexture({ width: 800, height: 600 });
    /// let renderTexture = new PIXI.RenderTexture(baseRenderTexture);
    /// let sprite = PIXI.Sprite.from("spinObj_01.png");
    /// 
    /// sprite.position.x = 800/2;
    /// sprite.position.y = 600/2;
    /// sprite.anchor.x = 0.5;
    /// sprite.anchor.y = 0.5;
    /// 
    /// renderer.render(sprite, renderTexture);
    /// ```
    /// 
    /// The Sprite in this case will be rendered using its local transform. To render this sprite at 0,0
    /// you can clear the transform
    /// 
    /// ```js
    /// 
    /// sprite.setTransform()
    /// 
    /// let baseRenderTexture = new PIXI.BaseRenderTexture({ width: 100, height: 100 });
    /// let renderTexture = new PIXI.RenderTexture(baseRenderTexture);
    /// 
    /// renderer.render(sprite, renderTexture);  // Renders to center of RenderTexture
    /// ```
    type [<AllowNullLiteral>] BaseRenderTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: BaseRenderTextureStaticOptions -> BaseRenderTexture

    type [<AllowNullLiteral>] BaseRenderTextureStaticOptions =
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract scaleMode: PIXI.SCALE_MODES option with get, set
        abstract resolution: float option with get, set

    /// A RenderTexture is a special texture that allows any PixiJS display object to be rendered to it.
    /// 
    /// __Hint__: All DisplayObjects (i.e. Sprites) that render to a RenderTexture should be preloaded
    /// otherwise black rectangles will be drawn instead.
    /// 
    /// __Hint-2__: The actual memory allocation will happen on first render.
    /// You shouldn't create renderTextures each frame just to delete them after, try to reuse them.
    /// 
    /// A RenderTexture takes a snapshot of any Display Object given to its render method. For example:
    /// 
    /// ```js
    /// let renderer = PIXI.autoDetectRenderer();
    /// let renderTexture = PIXI.RenderTexture.create(800, 600);
    /// let sprite = PIXI.Sprite.from("spinObj_01.png");
    /// 
    /// sprite.position.x = 800/2;
    /// sprite.position.y = 600/2;
    /// sprite.anchor.x = 0.5;
    /// sprite.anchor.y = 0.5;
    /// 
    /// renderer.render(sprite, renderTexture);
    /// ```
    /// 
    /// The Sprite in this case will be rendered using its local transform. To render this sprite at 0,0
    /// you can clear the transform
    /// 
    /// ```js
    /// 
    /// sprite.setTransform()
    /// 
    /// let renderTexture = new PIXI.RenderTexture.create(100, 100);
    /// 
    /// renderer.render(sprite, renderTexture);  // Renders to center of RenderTexture
    /// ```
    type [<AllowNullLiteral>] RenderTexture =
        inherit PIXI.Texture
        abstract sourceFrame: PIXI.Rectangle
        abstract size: PIXI.Rectangle
        /// This will let the renderer know if the texture is valid. If it's not then it cannot be rendered.
        abstract valid: bool with get, set
        /// FilterSystem temporary storage
        abstract filterFrame: PIXI.Rectangle with get, set
        /// The key for pooled texture of FilterSystem
        abstract filterPoolKey: string with get, set
        /// <summary>Resizes the RenderTexture.</summary>
        /// <param name="width">- The width to resize to.</param>
        /// <param name="height">- The height to resize to.</param>
        /// <param name="resizeBaseTexture">- Should the baseTexture.width and height values be resized as well?</param>
        abstract resize: width: float * height: float * ?resizeBaseTexture: bool -> unit
        /// <summary>Changes the resolution of baseTexture, but does not change framebuffer size.</summary>
        /// <param name="resolution">- The new resolution to apply to RenderTexture</param>
        abstract setResolution: resolution: float -> unit
        /// Does this Texture have any frame data assigned to it?
        /// 
        /// This mode is enabled automatically if no frame was passed inside constructor.
        /// 
        /// In this mode texture is subscribed to baseTexture events, and fires `update` on any change.
        /// 
        /// Beware, after loading or resize of baseTexture event can fired two times!
        /// If you want more control, subscribe on baseTexture itself.
        /// 
        /// ```js
        /// texture.on('update', () => {});
        /// ```
        /// 
        /// Any assignment of `frame` switches off `noFrame` mode.
        abstract noFrame: bool with get, set
        /// The base texture that this texture uses.
        abstract baseTexture: PIXI.BaseTexture with get, set
        /// This is the area of the BaseTexture image to actually copy to the Canvas / WebGL when rendering,
        /// irrespective of the actual frame size or placement (which can be influenced by trimmed texture atlases)
        abstract _frame: PIXI.Rectangle with get, set
        /// This is the trimmed area of original texture, before it was put in atlas
        /// Please call `updateUvs()` after you change coordinates of `trim` manually.
        abstract trim: PIXI.Rectangle with get, set
        /// This will let a renderer know that a texture has been updated (used mainly for WebGL uv updates)
        abstract requiresUpdate: bool with get, set
        /// The WebGL UV data cache. Can be used as quad UV
        abstract _uvs: PIXI.TextureUvs with get, set
        /// Default TextureMatrix instance for this texture
        /// By default that object is not created because its heavy
        abstract uvMatrix: PIXI.TextureMatrix with get, set
        /// This is the area of original texture, before it was put in atlas
        abstract orig: PIXI.Rectangle with get, set
        /// Anchor point that is used as default if sprite is created with this texture.
        /// Changing the `defaultAnchor` at a later point of time will not update Sprite's anchor point.
        abstract defaultAnchor: PIXI.Point with get, set
        /// Update ID is observed by sprites and TextureMatrix instances.
        /// Call updateUvs() to increment it.
        abstract _updateID: float with get, set
        /// The ids under which this Texture has been added to the texture cache. This is
        /// automatically set as long as Texture.addToCache is used, but may not be set if a
        /// Texture is added directly to the TextureCache array.
        abstract textureCacheIds: ResizeArray<string> with get, set
        /// Updates this texture on the gpu.
        /// 
        /// Calls the TextureResource update.
        /// 
        /// If you adjusted `frame` manually, please call `updateUvs()` instead.
        abstract update: unit -> unit
        /// <summary>Called when the base texture is updated</summary>
        /// <param name="baseTexture">- The base texture.</param>
        abstract onBaseTextureUpdated: baseTexture: PIXI.BaseTexture -> unit
        /// <summary>Destroys this texture</summary>
        /// <param name="destroyBase">Whether to destroy the base texture as well</param>
        abstract destroy: ?destroyBase: bool -> unit
        /// Creates a new texture object that acts the same as this one.
        abstract clone: unit -> PIXI.Texture
        /// Updates the internal WebGL UV cache. Use it after you change `frame` or `trim` of the texture.
        /// Call it after changing the frame
        abstract updateUvs: unit -> unit
        /// The frame specifies the region of the base texture that this texture uses.
        /// Please call `updateUvs()` after you change coordinates of `frame` manually.
        abstract frame: PIXI.Rectangle with get, set
        /// Indicates whether the texture is rotated inside the atlas
        /// set to 2 to compensate for texture packer rotation
        /// set to 6 to compensate for spine packer rotation
        /// can be used to rotate or mirror sprites
        /// See {@link PIXI.GroupD8} for explanation
        abstract rotate: float with get, set
        /// The width of the Texture in pixels.
        abstract width: float with get, set
        /// The height of the Texture in pixels.
        abstract height: float with get, set

    /// A RenderTexture is a special texture that allows any PixiJS display object to be rendered to it.
    /// 
    /// __Hint__: All DisplayObjects (i.e. Sprites) that render to a RenderTexture should be preloaded
    /// otherwise black rectangles will be drawn instead.
    /// 
    /// __Hint-2__: The actual memory allocation will happen on first render.
    /// You shouldn't create renderTextures each frame just to delete them after, try to reuse them.
    /// 
    /// A RenderTexture takes a snapshot of any Display Object given to its render method. For example:
    /// 
    /// ```js
    /// let renderer = PIXI.autoDetectRenderer();
    /// let renderTexture = PIXI.RenderTexture.create(800, 600);
    /// let sprite = PIXI.Sprite.from("spinObj_01.png");
    /// 
    /// sprite.position.x = 800/2;
    /// sprite.position.y = 600/2;
    /// sprite.anchor.x = 0.5;
    /// sprite.anchor.y = 0.5;
    /// 
    /// renderer.render(sprite, renderTexture);
    /// ```
    /// 
    /// The Sprite in this case will be rendered using its local transform. To render this sprite at 0,0
    /// you can clear the transform
    /// 
    /// ```js
    /// 
    /// sprite.setTransform()
    /// 
    /// let renderTexture = new PIXI.RenderTexture.create(100, 100);
    /// 
    /// renderer.render(sprite, renderTexture);  // Renders to center of RenderTexture
    /// ```
    type [<AllowNullLiteral>] RenderTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: baseRenderTexture: PIXI.BaseRenderTexture * ?frame: PIXI.Rectangle -> RenderTexture
        /// <summary>A short hand way of creating a render texture.</summary>
        /// <param name="options">- The resolution / device pixel ratio of the texture being generated</param>
        abstract create: ?options: RenderTextureStaticCreateOptions -> PIXI.RenderTexture

    type [<AllowNullLiteral>] RenderTextureStaticCreateOptions =
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract scaleMode: float option with get, set
        abstract resolution: float option with get, set

    /// Helper class to create a WebGL Program
    type [<AllowNullLiteral>] GLProgram =
        /// The shader program
        //TODO abstract program: WebGLProgram with get, set
        /// holds the uniform data which contains uniform locations
        /// and current uniform values used for caching and preventing unneeded GPU commands
        abstract uniformData: obj option with get, set
        /// uniformGroups holds the various upload functions for the shader. Each uniform group
        /// and program have a unique upload function generated.
        abstract uniformGroups: obj option with get, set
        /// Destroys this program
        abstract destroy: unit -> unit

    /// Helper class to create a WebGL Program
    type [<AllowNullLiteral>] GLProgramStatic =
        [<Emit "new $0($1...)">] abstract Create: program: WebGLProgram * uniformData: obj option -> GLProgram

    /// Helper class to create a shader program.
    type [<AllowNullLiteral>] Program =
        /// The vertex shader.
        abstract vertexSrc: string with get, set
        /// The fragment shader.
        abstract fragmentSrc: string with get, set
        /// <summary>Extracts the data for a buy creating a small test program
        /// or reading the src directly.</summary>
        /// <param name="vertexSrc">- The source of the vertex shader.</param>
        /// <param name="fragmentSrc">- The source of the fragment shader.</param>
        abstract extractData: ?vertexSrc: string * ?fragmentSrc: string -> unit

    /// Helper class to create a shader program.
    type [<AllowNullLiteral>] ProgramStatic =
        [<Emit "new $0($1...)">] abstract Create: ?vertexSrc: string * ?fragmentSrc: string * ?name: string -> Program
        /// The default vertex shader source
        abstract defaultVertexSrc: string with get, set
        /// The default fragment shader source
        abstract defaultFragmentSrc: string with get, set
        /// <summary>A short hand function to create a program based of a vertex and fragment shader
        /// this method will also check to see if there is a cached program.</summary>
        /// <param name="vertexSrc">- The source of the vertex shader.</param>
        /// <param name="fragmentSrc">- The source of the fragment shader.</param>
        /// <param name="uniforms">- Custom uniforms to use to augment the built-in ones.</param>
        abstract from: ?vertexSrc: string * ?fragmentSrc: string * ?uniforms: obj -> PIXI.Program

    /// A helper class for shaders
    type [<AllowNullLiteral>] Shader =
        /// Shader uniform values, shortcut for `uniformGroup.uniforms`
        abstract uniforms: obj option

    /// A helper class for shaders
    type [<AllowNullLiteral>] ShaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?program: PIXI.Program * ?uniforms: obj -> Shader
        /// <summary>A short hand function to create a shader based of a vertex and fragment shader</summary>
        /// <param name="vertexSrc">- The source of the vertex shader.</param>
        /// <param name="fragmentSrc">- The source of the fragment shader.</param>
        /// <param name="uniforms">- Custom uniforms to use to augment the built-in ones.</param>
        abstract from: ?vertexSrc: string * ?fragmentSrc: string * ?uniforms: obj -> PIXI.Shader

    /// Uniform group holds uniform map and some ID's for work
    type [<AllowNullLiteral>] UniformGroup =
        /// uniform values
        abstract uniforms: obj option
        /// Its a group and not a single uniforms
        abstract group: bool
        /// dirty version
        abstract dirtyId: float with get, set
        /// unique id
        abstract id: float with get, set
        /// Uniforms wont be changed after creation
        abstract ``static``: bool with get, set

    /// Uniform group holds uniform map and some ID's for work
    type [<AllowNullLiteral>] UniformGroupStatic =
        [<Emit "new $0($1...)">] abstract Create: ?uniforms: obj * ?_static: bool -> UniformGroup

    /// This is a WebGL state, and is is passed The WebGL StateManager.
    /// 
    /// Each mesh rendered may require WebGL to be in a different state.
    /// For example you may want different blend mode or to enable polygon offsets
    type [<AllowNullLiteral>] State =
        /// Activates blending of the computed fragment color values
        abstract blend: bool with get, set
        /// Activates adding an offset to depth values of polygon's fragments
        abstract offsets: bool with get, set
        /// Activates culling of polygons.
        abstract culling: bool with get, set
        /// Activates depth comparisons and updates to the depth buffer.
        abstract depthTest: bool with get, set
        /// Specifies whether or not front or back-facing polygons can be culled.
        abstract clockwiseFrontFace: bool with get, set
        /// The blend mode to be applied when this state is set. Apply a value of `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        /// Setting this mode to anything other than NO_BLEND will automatically switch blending on.
        abstract blendMode: float with get, set
        /// The polygon offset. Setting this property to anything other than 0 will automatically enable polygon offset fill.
        abstract polygonOffset: float with get, set

    /// This is a WebGL state, and is is passed The WebGL StateManager.
    /// 
    /// Each mesh rendered may require WebGL to be in a different state.
    /// For example you may want different blend mode or to enable polygon offsets
    type [<AllowNullLiteral>] StateStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> State

    /// System is a base class used for extending systems used by the {@link PIXI.Renderer}
    type [<AllowNullLiteral>] System =
        /// The renderer this manager works for.
        abstract renderer: PIXI.Renderer with get, set
        /// <summary>Generic method called when there is a WebGL context change.</summary>
        /// <param name="gl">new webgl context</param>
        abstract contextChange: gl: WebGLRenderingContext -> unit
        /// Generic destroy methods to be overridden by the subclass
        abstract destroy: unit -> unit

    /// System is a base class used for extending systems used by the {@link PIXI.Renderer}
    type [<AllowNullLiteral>] SystemStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> System

    module Systems =

        type [<AllowNullLiteral>] IExports =
            abstract BatchSystem: BatchSystemStatic
            abstract ContextSystem: ContextSystemStatic
            abstract FilterSystem: FilterSystemStatic
            abstract FramebufferSystem: FramebufferSystemStatic
            abstract GeometrySystem: GeometrySystemStatic
            abstract MaskSystem: MaskSystemStatic
            abstract StencilSystem: StencilSystemStatic
            abstract ProjectionSystem: ProjectionSystemStatic
            abstract RenderTextureSystem: RenderTextureSystemStatic
            abstract ShaderSystem: ShaderSystemStatic
            abstract StateSystem: StateSystemStatic
            abstract TextureGCSystem: TextureGCSystemStatic
            abstract TextureSystem: TextureSystemStatic

        /// System plugin to the renderer to manage batching.
        type [<AllowNullLiteral>] BatchSystem =
            inherit PIXI.System
            /// An empty renderer.
            abstract emptyRenderer: PIXI.ObjectRenderer with get, set
            /// The currently active ObjectRenderer.
            abstract currentRenderer: PIXI.ObjectRenderer with get, set
            /// <summary>Changes the current renderer to the one given in parameter</summary>
            /// <param name="objectRenderer">- The object renderer to use.</param>
            abstract setObjectRenderer: objectRenderer: PIXI.ObjectRenderer -> unit
            /// This should be called if you wish to do some custom rendering
            /// It will basically render anything that may be batched up such as sprites
            abstract flush: unit -> unit
            /// Reset the system to an empty renderer
            abstract reset: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage batching.
        type [<AllowNullLiteral>] BatchSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> BatchSystem

        /// System plugin to the renderer to manage the context.
        type [<AllowNullLiteral>] ContextSystem =
            inherit PIXI.System
            /// Either 1 or 2 to reflect the WebGL version being used
            abstract webGLVersion: float
            /// Extensions being used
            //TODO abstract extensions: TypeLiteral_01
            /// `true` if the context is lost
            abstract isLost: bool
            /// <summary>Handle the context change event</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// <summary>Initialize the context</summary>
            /// <param name="gl">- WebGL context</param>
            abstract initFromContext: gl: WebGLRenderingContext -> unit
            /// <summary>Initialize from context options</summary>
            /// <param name="options">- context attributes</param>
            abstract initFromOptions: options: obj option -> unit
            /// <summary>Helper class to create a WebGL Context</summary>
            /// <param name="canvas">the canvas element that we will get the context from</param>
            /// <param name="options">An options object that gets passed in to the canvas element containing the context attributes</param>
            abstract createContext: canvas: Browser.Types.HTMLCanvasElement * options: obj option -> WebGLRenderingContext
            /// Auto-populate the extensions
            abstract getExtensions: unit -> unit
            /// <summary>Handles a lost webgl context</summary>
            /// <param name="event">- The context lost event.</param>
            abstract handleContextLost: ``event``: WebGLContextEvent -> unit
            /// Handles a restored webgl context
            abstract handleContextRestored: unit -> unit
            /// Handle the post-render runner event
            abstract postrender: unit -> unit
            /// <summary>Validate context</summary>
            /// <param name="gl">- Render context</param>
            abstract validateContext: gl: WebGLRenderingContext -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage the context.
        type [<AllowNullLiteral>] ContextSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> ContextSystem

        /// System plugin to the renderer to manage the filters.
        type [<AllowNullLiteral>] FilterSystem =
            inherit PIXI.System
            /// <param name="outputMatrix">- the matrix to output to.</param>
            abstract calculateScreenSpaceMatrix: outputMatrix: PIXI.Matrix -> PIXI.Matrix
            /// <param name="outputMatrix">- The matrix to output to.</param>
            abstract calculateNormalizedScreenSpaceMatrix: outputMatrix: PIXI.Matrix -> PIXI.Matrix
            /// List of filters for the FilterSystem
            abstract defaultFilterStack: ResizeArray<obj option>
            /// stores a bunch of PO2 textures used for filtering
            abstract texturePool: obj option with get, set
            /// a pool for storing filter states, save us creating new ones each tick
            abstract statePool: ResizeArray<obj option> with get, set
            /// A very simple geometry used when drawing a filter effect to the screen
            abstract quad: PIXI.Quad with get, set
            /// Quad UVs
            abstract quadUv: PIXI.QuadUv with get, set
            /// Temporary rect for maths
            abstract tempRect: PIXI.Rectangle with get, set
            /// Active state
            abstract activeState: obj option with get, set
            /// This uniform group is attached to filter uniforms when used
            abstract globalUniforms: PIXI.UniformGroup with get, set
            /// <summary>Adds a new filter to the System.</summary>
            /// <param name="target">- The target of the filter to render.</param>
            /// <param name="filters">- The filters to apply.</param>
            abstract push: target: PIXI.DisplayObject * filters: ResizeArray<PIXI.Filter> -> unit
            /// Pops off the filter and applies it.
            abstract pop: unit -> unit
            /// <summary>Draws a filter.</summary>
            /// <param name="filter">- The filter to draw.</param>
            /// <param name="input">- The input render target.</param>
            /// <param name="output">- The target to output to.</param>
            /// <param name="clear">- Should the output be cleared before rendering to it</param>
            abstract applyFilter: filter: PIXI.Filter * input: PIXI.RenderTexture * output: PIXI.RenderTexture * clear: bool -> unit
            /// <summary>Multiply _input normalized coordinates_ to this matrix to get _sprite texture normalized coordinates_.
            /// 
            /// Use `outputMatrix * vTextureCoord` in the shader.</summary>
            /// <param name="outputMatrix">- The matrix to output to.</param>
            /// <param name="sprite">- The sprite to map to.</param>
            abstract calculateSpriteMatrix: outputMatrix: PIXI.Matrix * sprite: PIXI.Sprite -> PIXI.Matrix
            /// <summary>Destroys this Filter System.</summary>
            /// <param name="contextLost">context was lost, do not free shaders</param>
            abstract destroy: ?contextLost: bool -> unit
            /// <summary>Gets a Power-of-Two render texture or fullScreen texture
            /// 
            /// TODO move to a separate class could be on renderer?</summary>
            /// <param name="minWidth">- The minimum width of the render texture in real pixels.</param>
            /// <param name="minHeight">- The minimum height of the render texture in real pixels.</param>
            /// <param name="resolution">- The resolution of the render texture.</param>
            abstract getOptimalFilterTexture: minWidth: float * minHeight: float * ?resolution: float -> PIXI.RenderTexture
            /// <summary>Gets extra render texture to use inside current filter</summary>
            /// <param name="resolution">resolution of the renderTexture</param>
            abstract getFilterTexture: resolution: float -> PIXI.RenderTexture
            /// <summary>Frees a render texture back into the pool.</summary>
            /// <param name="renderTexture">- The renderTarget to free</param>
            abstract returnFilterTexture: renderTexture: PIXI.RenderTexture -> unit
            /// Empties the texture pool.
            abstract emptyPool: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit

        /// System plugin to the renderer to manage the filters.
        type [<AllowNullLiteral>] FilterSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> FilterSystem

        /// System plugin to the renderer to manage framebuffers.
        type [<AllowNullLiteral>] FramebufferSystem =
            inherit PIXI.System
            /// A list of managed framebuffers
            abstract managedFramebuffers: ResizeArray<PIXI.Framebuffer>
            /// Framebuffer value that shows that we don't know what is bound
            abstract unknownFramebuffer: Framebuffer
            /// Sets up the renderer context and necessary buffers.
            abstract contextChange: unit -> unit
            /// <summary>Bind a framebuffer</summary>
            /// <param name="framebuffer"></param>
            /// <param name="frame">frame, default is framebuffer size</param>
            abstract bind: framebuffer: PIXI.Framebuffer * ?frame: PIXI.Rectangle -> unit
            /// <summary>Set the WebGLRenderingContext's viewport.</summary>
            /// <param name="x">- X position of viewport</param>
            /// <param name="y">- Y position of viewport</param>
            /// <param name="width">- Width of viewport</param>
            /// <param name="height">- Height of viewport</param>
            abstract setViewport: x: float * y: float * width: float * height: float -> unit
            /// Get the size of the current width and height. Returns object with `width` and `height` values.
            abstract size: obj option
            /// <summary>Clear the color of the context</summary>
            /// <param name="r">- Red value from 0 to 1</param>
            /// <param name="g">- Green value from 0 to 1</param>
            /// <param name="b">- Blue value from 0 to 1</param>
            /// <param name="a">- Alpha value from 0 to 1</param>
            abstract clear: r: float * g: float * b: float * a: float -> unit
            /// <summary>Initialize framebuffer</summary>
            /// <param name="framebuffer"></param>
            abstract initFramebuffer: framebuffer: PIXI.Framebuffer -> unit
            /// <summary>Resize the framebuffer</summary>
            /// <param name="framebuffer"></param>
            abstract resizeFramebuffer: framebuffer: PIXI.Framebuffer -> unit
            /// <summary>Update the framebuffer</summary>
            /// <param name="framebuffer"></param>
            abstract updateFramebuffer: framebuffer: PIXI.Framebuffer -> unit
            /// <summary>Disposes framebuffer</summary>
            /// <param name="framebuffer">framebuffer that has to be disposed of</param>
            /// <param name="contextLost">If context was lost, we suppress all delete function calls</param>
            abstract disposeFramebuffer: framebuffer: PIXI.Framebuffer * ?contextLost: bool -> unit
            /// <summary>Disposes all framebuffers, but not textures bound to them</summary>
            /// <param name="contextLost">If context was lost, we suppress all delete function calls</param>
            abstract disposeAll: ?contextLost: bool -> unit
            /// resets framebuffer stored state, binds screen framebuffer
            /// 
            /// should be called before renderTexture reset()
            abstract reset: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage framebuffers.
        type [<AllowNullLiteral>] FramebufferSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> FramebufferSystem

        /// System plugin to the renderer to manage geometry.
        type [<AllowNullLiteral>] GeometrySystem =
            inherit PIXI.System
            /// `true` if we has `*_vertex_array_object` extension
            abstract hasVao: bool
            /// `true` if has `ANGLE_instanced_arrays` extension
            abstract hasInstance: bool
            /// `true` if support `gl.UNSIGNED_INT` in `gl.drawElements` or `gl.drawElementsInstanced`
            abstract canUseUInt32ElementIndex: bool
            /// A cache of currently bound buffer,
            /// contains only two members with keys ARRAY_BUFFER and ELEMENT_ARRAY_BUFFER
            abstract boundBuffers: TypeLiteral_02
            /// Cache for all geometries by id, used in case renderer gets destroyed or for profiling
            abstract managedGeometries: obj option
            /// Cache for all buffers by id, used in case renderer gets destroyed or for profiling
            abstract managedBuffers: obj option
            /// Sets up the renderer context and necessary buffers.
            abstract contextChange: unit -> unit
            /// <summary>Binds geometry so that is can be drawn. Creating a Vao if required</summary>
            /// <param name="geometry">instance of geometry to bind</param>
            /// <param name="shader">instance of shader to use vao for</param>
            abstract bind: geometry: PIXI.Geometry * ?shader: PIXI.Shader -> unit
            /// Reset and unbind any active VAO and geometry
            abstract reset: unit -> unit
            /// Update buffers
            abstract updateBuffers: unit -> unit
            /// <summary>Check compability between a geometry and a program</summary>
            /// <param name="geometry">- Geometry instance</param>
            /// <param name="program">- Program instance</param>
            abstract checkCompatibility: geometry: PIXI.Geometry * program: PIXI.Program -> unit
            /// <summary>Takes a geometry and program and generates a unique signature for them.</summary>
            /// <param name="geometry">to get signature from</param>
            /// <param name="program">to test geometry against</param>
            abstract getSignature: geometry: PIXI.Geometry * program: PIXI.Program -> string
            /// <summary>Creates or gets Vao with the same structure as the geometry and stores it on the geometry.
            /// If vao is created, it is bound automatically.</summary>
            /// <param name="geometry">- Instance of geometry to to generate Vao for</param>
            /// <param name="program">- Instance of program</param>
            abstract initGeometryVao: geometry: PIXI.Geometry * program: PIXI.Program -> unit
            /// <summary>Disposes buffer</summary>
            /// <param name="buffer">buffer with data</param>
            /// <param name="contextLost">If context was lost, we suppress deleteVertexArray</param>
            abstract disposeBuffer: buffer: PIXI.Buffer * ?contextLost: bool -> unit
            /// <summary>Disposes geometry</summary>
            /// <param name="geometry">Geometry with buffers. Only VAO will be disposed</param>
            /// <param name="contextLost">If context was lost, we suppress deleteVertexArray</param>
            abstract disposeGeometry: geometry: PIXI.Geometry * ?contextLost: bool -> unit
            /// <summary>dispose all WebGL resources of all managed geometries and buffers</summary>
            /// <param name="contextLost">If context was lost, we suppress `gl.delete` calls</param>
            abstract disposeAll: ?contextLost: bool -> unit
            /// <summary>Activate vertex array object</summary>
            /// <param name="geometry">- Geometry instance</param>
            /// <param name="program">- Shader program instance</param>
            abstract activateVao: geometry: PIXI.Geometry * program: PIXI.Program -> unit
            /// <summary>Draw the geometry</summary>
            /// <param name="type">- the type primitive to render</param>
            /// <param name="size">- the number of elements to be rendered</param>
            /// <param name="start">- Starting index</param>
            /// <param name="instanceCount">- the number of instances of the set of elements to execute</param>
            abstract draw: ``type``: float * ?size: float * ?start: float * ?instanceCount: float -> unit
            /// Unbind/reset everything
            abstract unbind: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage geometry.
        type [<AllowNullLiteral>] GeometrySystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> GeometrySystem

        /// System plugin to the renderer to manage masks.
        type [<AllowNullLiteral>] MaskSystem =
            inherit PIXI.System
            /// `true` if current pushed masked is scissor
            abstract scissor: bool
            /// Mask data
            abstract scissorData: PIXI.Graphics
            /// Target to mask
            abstract scissorRenderTarget: PIXI.DisplayObject
            /// Enable scissor
            abstract enableScissor: bool
            /// Pool of used sprite mask filters
            abstract alphaMaskPool: ResizeArray<PIXI.SpriteMaskFilter>
            /// Current index of alpha mask pool
            abstract alphaMaskIndex: float
            /// <summary>Applies the Mask and adds it to the current filter stack.</summary>
            /// <param name="target">- Display Object to push the mask to</param>
            /// <param name="maskData">- The masking data.</param>
            abstract push: target: PIXI.DisplayObject * maskData: U2<PIXI.Sprite, PIXI.Graphics> -> unit
            /// <summary>Removes the last mask from the mask stack and doesn't return it.</summary>
            /// <param name="target">- Display Object to pop the mask from</param>
            /// <param name="maskData">- The masking data.</param>
            abstract pop: target: PIXI.DisplayObject * maskData: U2<PIXI.Sprite, PIXI.Graphics> -> unit
            /// <summary>Applies the Mask and adds it to the current filter stack.</summary>
            /// <param name="target">- Display Object to push the sprite mask to</param>
            /// <param name="maskData">- Sprite to be used as the mask</param>
            abstract pushSpriteMask: target: PIXI.RenderTexture * maskData: PIXI.Sprite -> unit
            /// Removes the last filter from the filter stack and doesn't return it.
            abstract popSpriteMask: unit -> unit
            /// <summary>Applies the Mask and adds it to the current filter stack.</summary>
            /// <param name="maskData">- The masking data.</param>
            abstract pushStencilMask: maskData: U2<PIXI.Sprite, PIXI.Graphics> -> unit
            /// Removes the last filter from the filter stack and doesn't return it.
            abstract popStencilMask: unit -> unit
            /// <param name="target">- Display Object to push the mask to</param>
            /// <param name="maskData">- The masking data.</param>
            abstract pushScissorMask: target: PIXI.DisplayObject * maskData: PIXI.Graphics -> unit
            /// Pop scissor mask
            abstract popScissorMask: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage masks.
        type [<AllowNullLiteral>] MaskSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> MaskSystem

        /// System plugin to the renderer to manage stencils (used for masks).
        type [<AllowNullLiteral>] StencilSystem =
            inherit PIXI.System
            /// The mask stack
            abstract stencilMaskStack: ResizeArray<PIXI.Graphics> with get, set
            /// <summary>Changes the mask stack that is used by this System.</summary>
            /// <param name="stencilMaskStack">- The mask stack</param>
            abstract setMaskStack: stencilMaskStack: ResizeArray<PIXI.Graphics> -> unit
            /// <summary>Applies the Mask and adds it to the current stencil stack. @alvin</summary>
            /// <param name="graphics">- The mask</param>
            abstract pushStencil: graphics: PIXI.Graphics -> unit
            /// Removes the last mask from the stencil stack. @alvin
            abstract popStencil: unit -> unit
            /// Destroys the mask stack.
            abstract destroy: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit

        /// System plugin to the renderer to manage stencils (used for masks).
        type [<AllowNullLiteral>] StencilSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> StencilSystem

        /// System plugin to the renderer to manage the projection matrix.
        type [<AllowNullLiteral>] ProjectionSystem =
            inherit PIXI.System
            /// Destination frame
            abstract destinationFrame: PIXI.Rectangle
            /// Source frame
            abstract sourceFrame: PIXI.Rectangle
            /// Default destination frame
            abstract defaultFrame: PIXI.Rectangle
            /// Project matrix
            abstract projectionMatrix: PIXI.Matrix
            /// A transform that will be appended to the projection matrix
            /// if null, nothing will be applied
            abstract transform: PIXI.Matrix with get, set
            /// <summary>Updates the projection matrix based on a projection frame (which is a rectangle)</summary>
            /// <param name="destinationFrame">- The destination frame.</param>
            /// <param name="sourceFrame">- The source frame.</param>
            /// <param name="resolution">- Resolution</param>
            /// <param name="root">- If is root</param>
            abstract update: destinationFrame: PIXI.Rectangle * sourceFrame: PIXI.Rectangle * resolution: float * root: bool -> unit
            /// <summary>Updates the projection matrix based on a projection frame (which is a rectangle)</summary>
            /// <param name="destinationFrame">- The destination frame.</param>
            /// <param name="sourceFrame">- The source frame.</param>
            /// <param name="resolution">- Resolution</param>
            /// <param name="root">- If is root</param>
            abstract calculateProjection: destinationFrame: PIXI.Rectangle * sourceFrame: PIXI.Rectangle * resolution: float * root: bool -> unit
            /// <summary>Sets the transform of the active render target to the given matrix</summary>
            /// <param name="matrix">- The transformation matrix</param>
            abstract setTransform: matrix: PIXI.Matrix -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage the projection matrix.
        type [<AllowNullLiteral>] ProjectionSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> ProjectionSystem

        /// System plugin to the renderer to manage render textures.
        /// 
        /// Should be added after FramebufferSystem
        type [<AllowNullLiteral>] RenderTextureSystem =
            inherit PIXI.System
            /// The clear background color as rgba
            abstract clearColor: ResizeArray<float> with get, set
            /// List of masks for the StencilSystem
            abstract defaultMaskStack: ResizeArray<PIXI.Graphics>
            /// Render texture
            abstract current: PIXI.RenderTexture
            /// Source frame
            abstract sourceFrame: PIXI.Rectangle
            /// Destination frame
            abstract destinationFrame: PIXI.Rectangle
            /// <summary>Bind the current render texture</summary>
            /// <param name="renderTexture">- RenderTexture to bind, by default its `null`, the screen</param>
            /// <param name="sourceFrame">- part of screen that is mapped to the renderTexture</param>
            /// <param name="destinationFrame">- part of renderTexture, by default it has the same size as sourceFrame</param>
            abstract bind: ?renderTexture: PIXI.RenderTexture * ?sourceFrame: PIXI.Rectangle * ?destinationFrame: PIXI.Rectangle -> unit
            /// <summary>Erases the render texture and fills the drawing area with a colour</summary>
            /// <param name="clearColor">- The color as rgba, default to use the renderer backgroundColor</param>
            abstract clear: ?clearColor: ResizeArray<float> -> PIXI.Renderer
            /// Resets renderTexture state
            abstract reset: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage render textures.
        /// 
        /// Should be added after FramebufferSystem
        type [<AllowNullLiteral>] RenderTextureSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> RenderTextureSystem

        /// System plugin to the renderer to manage shaders.
        type [<AllowNullLiteral>] ShaderSystem =
            inherit PIXI.System
            /// The current WebGL rendering context
            //abstract gl: WebGLRenderingContext with get, set
            /// <summary>Changes the current shader to the one given in parameter</summary>
            /// <param name="shader">- the new shader</param>
            /// <param name="dontSync">- false if the shader should automatically sync its uniforms.</param>
            abstract bind: shader: PIXI.Shader * dontSync: bool -> PIXI.GLProgram
            /// <summary>Uploads the uniforms values to the currently bound shader.</summary>
            /// <param name="uniforms">- the uniforms values that be applied to the current shader</param>
            abstract setUniforms: uniforms: obj option -> unit
            /// Returns the underlying GLShade rof the currently bound shader.
            /// This can be handy for when you to have a little more control over the setting of your uniforms.
            abstract getglProgram: unit -> PIXI.GLProgram
            /// Resets ShaderSystem state, does not affect WebGL state
            abstract reset: unit -> unit
            /// Destroys this System and removes all its textures
            abstract destroy: unit -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit

        /// System plugin to the renderer to manage shaders.
        type [<AllowNullLiteral>] ShaderSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> ShaderSystem

        /// System plugin to the renderer to manage WebGL state machines.
        type [<AllowNullLiteral>] StateSystem =
            inherit PIXI.System
            abstract setState: unit -> unit
            /// GL context
            abstract gl: WebGLRenderingContext
            /// State ID
            abstract stateId: float
            /// Polygon offset
            abstract polygonOffset: float
            /// Blend mode
            abstract blendMode: float
            /// Whether current blend equation is different
            abstract _blendEq: bool with get, set
            /// Collection of calls
            abstract map: ResizeArray<(ResizeArray<obj option> -> obj option)>
            /// Collection of check calls
            abstract checks: ResizeArray<(ResizeArray<obj option> -> obj option)>
            /// Default WebGL State
            abstract defaultState: PIXI.State
            /// <summary>Sets the current state</summary>
            /// <param name="state">- The state to set.</param>
            abstract set: state: obj option -> unit
            /// <summary>Sets the state, when previous state is unknown</summary>
            /// <param name="state">- The state to set</param>
            abstract forceState: state: obj option -> unit
            /// <summary>Enables or disabled blending.</summary>
            /// <param name="value">- Turn on or off webgl blending.</param>
            abstract setBlend: value: bool -> unit
            /// <summary>Enables or disable polygon offset fill</summary>
            /// <param name="value">- Turn on or off webgl polygon offset testing.</param>
            abstract setOffset: value: bool -> unit
            /// <summary>Sets whether to enable or disable depth test.</summary>
            /// <param name="value">- Turn on or off webgl depth testing.</param>
            abstract setDepthTest: value: bool -> unit
            /// <summary>Sets whether to enable or disable cull face.</summary>
            /// <param name="value">- Turn on or off webgl cull face.</param>
            abstract setCullFace: value: bool -> unit
            /// <summary>Sets the gl front face.</summary>
            /// <param name="value">- true is clockwise and false is counter-clockwise</param>
            abstract setFrontFace: value: bool -> unit
            /// <summary>Sets the blend mode.</summary>
            /// <param name="value">- The blend mode to set to.</param>
            abstract setBlendMode: value: float -> unit
            /// <summary>Sets the polygon offset.</summary>
            /// <param name="value">- the polygon offset</param>
            /// <param name="scale">- the polygon offset scale</param>
            abstract setPolygonOffset: value: float * scale: float -> unit
            /// Resets all the logic and disables the vaos
            abstract reset: unit -> unit
            /// <summary>checks to see which updates should be checked based on which settings have been activated.
            /// For example, if blend is enabled then we should check the blend modes each time the state is changed
            /// or if polygon fill is activated then we need to check if the polygon offset changes.
            /// The idea is that we only check what we have too.</summary>
            /// <param name="func">the checking function to add or remove</param>
            /// <param name="value">should the check function be added or removed.</param>
            abstract updateCheck: func: (ResizeArray<obj option> -> obj option) * value: bool -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage WebGL state machines.
        type [<AllowNullLiteral>] StateSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> StateSystem

        /// System plugin to the renderer to manage texture garbage collection on the GPU,
        /// ensuring that it does not get clogged up with textures that are no longer being used.
        type [<AllowNullLiteral>] TextureGCSystem =
            inherit PIXI.System
            /// Count
            abstract count: float
            /// Check count
            abstract checkCount: float
            /// Maximum idle time, in seconds
            abstract maxIdle: float with get, set
            /// Maximum number of itesm to check
            abstract checkCountMax: float with get, set
            /// Current garabage collection mode
            abstract mode: PIXI.GC_MODES with get, set
            /// Checks to see when the last time a texture was used
            /// if the texture has not been used for a specified amount of time it will be removed from the GPU
            abstract postrender: unit -> unit
            /// Checks to see when the last time a texture was used
            /// if the texture has not been used for a specified amount of time it will be removed from the GPU
            abstract run: unit -> unit
            /// <summary>Removes all the textures within the specified displayObject and its children from the GPU</summary>
            /// <param name="displayObject">- the displayObject to remove the textures from.</param>
            abstract unload: displayObject: PIXI.DisplayObject -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// <summary>Generic method called when there is a WebGL context change.</summary>
            /// <param name="gl">new webgl context</param>
            abstract contextChange: gl: WebGLRenderingContext -> unit
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage texture garbage collection on the GPU,
        /// ensuring that it does not get clogged up with textures that are no longer being used.
        type [<AllowNullLiteral>] TextureGCSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> TextureGCSystem

        /// System plugin to the renderer to manage textures.
        type [<AllowNullLiteral>] TextureSystem =
            inherit PIXI.System
            /// Bound textures
            abstract boundTextures: ResizeArray<PIXI.BaseTexture>
            /// Current location
            abstract currentLocation: float
            /// List of managed textures
            abstract managedTextures: ResizeArray<PIXI.BaseTexture>
            /// BaseTexture value that shows that we don't know what is bound
            abstract unknownTexture: PIXI.BaseTexture
            /// Sets up the renderer context and necessary buffers.
            abstract contextChange: unit -> unit
            /// <summary>Bind a texture to a specific location
            /// 
            /// If you want to unbind something, please use `unbind(texture)` instead of `bind(null, textureLocation)`</summary>
            /// <param name="texture">- Texture to bind</param>
            /// <param name="location">- Location to bind at</param>
            abstract bind: texture: U2<PIXI.Texture, PIXI.BaseTexture> * ?location: float -> unit
            /// Resets texture location and bound textures
            /// 
            /// Actual `bind(null, i)` calls will be performed at next `unbind()` call
            abstract reset: unit -> unit
            /// <summary>Unbind a texture</summary>
            /// <param name="texture">- Texture to bind</param>
            abstract unbind: texture: U2<PIXI.Texture, PIXI.BaseTexture> -> unit
            /// The renderer this manager works for.
            abstract renderer: PIXI.Renderer with get, set
            /// Generic destroy methods to be overridden by the subclass
            abstract destroy: unit -> unit

        /// System plugin to the renderer to manage textures.
        type [<AllowNullLiteral>] TextureSystemStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> TextureSystem

        type [<AllowNullLiteral>] TypeLiteral_02 =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> PIXI.Buffer with get, set

    /// A Texture stores the information that represents an image.
    /// All textures have a base texture, which contains information about the source.
    /// Therefore you can have many textures all using a single BaseTexture
    type [<AllowNullLiteral>] BaseTexture =
        inherit PIXI.Utils.EventEmitter
        abstract loadSource: unit -> unit
        abstract hasLoaded: bool
        abstract imageUrl: string
        abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
        /// The width of the base texture set when the image has loaded
        abstract width: float
        /// The height of the base texture set when the image has loaded
        abstract height: float
        /// The resolution / device pixel ratio of the texture
        abstract resolution: float with get, set
        /// Mipmap mode of the texture, affects downscaled images
        abstract mipmap: PIXI.MIPMAP_MODES with get, set
        /// Anisotropic filtering level of texture
        abstract anisotropicLevel: float with get, set
        /// How the texture wraps
        abstract wrapMode: float with get, set
        /// The scale mode to apply when scaling this texture
        abstract scaleMode: PIXI.SCALE_MODES with get, set
        /// The pixel format of the texture
        abstract format: PIXI.FORMATS with get, set
        /// The type of resource data
        abstract ``type``: PIXI.TYPES with get, set
        /// The target type
        abstract target: PIXI.TARGETS with get, set
        /// Set to true to enable pre-multiplied alpha
        abstract premultiplyAlpha: bool with get, set
        /// Global unique identifier for this BaseTexture
        abstract uid: string with get, set
        /// Used by automatic texture Garbage Collection, stores last GC tick when it was bound
        abstract touched: float with get, set
        /// Whether or not the texture is a power of two, try to use power of two textures as much
        /// as you can
        abstract isPowerOfTwo: bool
        /// Used by TextureSystem to only update texture to the GPU when needed.
        /// Please call `update()` to increment it.
        abstract dirtyId: float
        /// Used by TextureSystem to only update texture style when needed.
        abstract dirtyStyleId: float with get, set
        /// Currently default cache ID.
        abstract cacheId: string with get, set
        /// Generally speaking means when resource is loaded.
        abstract valid: bool
        /// The collection of alternative cache ids, since some BaseTextures
        /// can have more than one ID, short name and longer full URL
        abstract textureCacheIds: ResizeArray<string>
        /// Flag if BaseTexture has been destroyed.
        abstract destroyed: bool
        /// The resource used by this BaseTexture, there can only
        /// be one resource per BaseTexture, but textures can share
        /// resources.
        abstract resource: PIXI.Resources.Resource
        /// Number of the texture batch, used by multi-texture renderers
        abstract _batchEnabled: float with get, set
        /// Pixel width of the source of this texture
        abstract realWidth: float
        /// Pixel height of the source of this texture
        abstract realHeight: float
        /// <summary>Changes style options of BaseTexture</summary>
        /// <param name="scaleMode">- Pixi scalemode</param>
        /// <param name="mipmap">- enable mipmaps</param>
        abstract setStyle: ?scaleMode: PIXI.SCALE_MODES * ?mipmap: PIXI.MIPMAP_MODES -> PIXI.BaseTexture
        /// <summary>Changes w/h/resolution. Texture becomes valid if width and height are greater than zero.</summary>
        /// <param name="width">Visual width</param>
        /// <param name="height">Visual height</param>
        /// <param name="resolution">Optionally set resolution</param>
        abstract setSize: width: float * height: float * ?resolution: float -> PIXI.BaseTexture
        /// <summary>Sets real size of baseTexture, preserves current resolution.</summary>
        /// <param name="realWidth">Full rendered width</param>
        /// <param name="realHeight">Full rendered height</param>
        /// <param name="resolution">Optionally set resolution</param>
        abstract setRealSize: realWidth: float * realHeight: float * ?resolution: float -> PIXI.BaseTexture
        /// <summary>Changes resolution</summary>
        /// <param name="resolution">res</param>
        abstract setResolution: ?resolution: float -> PIXI.BaseTexture
        /// <summary>Sets the resource if it wasn't set. Throws error if resource already present</summary>
        /// <param name="resource">- that is managing this BaseTexture</param>
        abstract setResource: resource: PIXI.Resources.Resource -> PIXI.BaseTexture
        /// Invalidates the object. Texture becomes valid if width and height are greater than zero.
        abstract update: unit -> unit
        /// Destroys this base texture.
        /// The method stops if resource doesn't want this texture to be destroyed.
        /// Removes texture from all caches.
        abstract destroy: unit -> unit
        /// Frees the texture from WebGL memory without destroying this texture object.
        /// This means you can still use the texture later which will upload it to GPU
        /// memory again.
        abstract dispose: unit -> unit

    /// A Texture stores the information that represents an image.
    /// All textures have a base texture, which contains information about the source.
    /// Therefore you can have many textures all using a single BaseTexture
    type [<AllowNullLiteral>] BaseTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: ?resource: U5<PIXI.Resources.Resource, string, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement> * ?options: BaseTextureStaticOptions -> BaseTexture
        abstract fromImage: unit -> unit
        abstract fromCanvas: unit -> unit
        abstract fromSVG: unit -> unit
        /// <summary>Helper function that creates a base texture based on the source you provide.
        /// The source can be - image url, image element, canvas element. If the
        /// source is an image url or an image element and not in the base texture
        /// cache, it will be created and loaded.</summary>
        /// <param name="source">- The
        /// source to create base texture from.</param>
        /// <param name="options">See {</param>
        abstract from: source: U5<string, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.SVGElement, Browser.Types.HTMLVideoElement> * ?options: obj -> PIXI.BaseTexture
        /// <summary>Create a new BaseTexture with a BufferResource from a float [].
        /// RGBA values are floats from 0 to 1.</summary>
        /// <param name="buffer">The optional array to use, if no data
        /// is provided, a new float [] is created.</param>
        /// <param name="width">- Width of the resource</param>
        /// <param name="height">- Height of the resource</param>
        /// <param name="options">See {</param>
        abstract fromBuffer: buffer: float [] * width: float * height: float * ?options: obj -> PIXI.BaseTexture
        abstract fromBuffer: buffer: int [] * width: float * height: float * ?options: obj -> PIXI.BaseTexture
        /// <summary>Adds a BaseTexture to the global BaseTextureCache. This cache is shared across the whole PIXI object.</summary>
        /// <param name="baseTexture">- The BaseTexture to add to the cache.</param>
        /// <param name="id">- The id that the BaseTexture will be stored against.</param>
        abstract addToCache: baseTexture: PIXI.BaseTexture * id: string -> unit
        /// <summary>Remove a BaseTexture from the global BaseTextureCache.</summary>
        /// <param name="baseTexture">- id of a BaseTexture to be removed, or a BaseTexture instance itself.</param>
        abstract removeFromCache: baseTexture: U2<string, PIXI.BaseTexture> -> PIXI.BaseTexture option
        /// Global number of the texture batch, used by multi-texture renderers
        abstract _globalBatch: float with get, set

    type [<AllowNullLiteral>] BaseTextureStaticOptions =
        abstract mipmap: PIXI.MIPMAP_MODES option with get, set
        abstract anisotropicLevel: float option with get, set
        abstract wrapMode: PIXI.WRAP_MODES option with get, set
        abstract scaleMode: PIXI.SCALE_MODES option with get, set
        abstract format: PIXI.FORMATS option with get, set
        abstract ``type``: PIXI.TYPES option with get, set
        abstract target: PIXI.TARGETS option with get, set
        abstract premultiplyAlpha: bool option with get, set
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract resourceOptions: obj option with get, set

    /// A Texture that depends on six other resources.
    type [<AllowNullLiteral>] CubeTexture =
        inherit PIXI.BaseTexture
        abstract loadSource: unit -> unit
        abstract hasLoaded: bool
        abstract imageUrl: string
        abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
        /// The width of the base texture set when the image has loaded
        abstract width: float
        /// The height of the base texture set when the image has loaded
        abstract height: float
        /// The resolution / device pixel ratio of the texture
        abstract resolution: float with get, set
        /// Mipmap mode of the texture, affects downscaled images
        abstract mipmap: PIXI.MIPMAP_MODES with get, set
        /// Anisotropic filtering level of texture
        abstract anisotropicLevel: float with get, set
        /// How the texture wraps
        abstract wrapMode: float with get, set
        /// The scale mode to apply when scaling this texture
        abstract scaleMode: PIXI.SCALE_MODES with get, set
        /// The pixel format of the texture
        abstract format: PIXI.FORMATS with get, set
        /// The type of resource data
        abstract ``type``: PIXI.TYPES with get, set
        /// The target type
        abstract target: PIXI.TARGETS with get, set
        /// Set to true to enable pre-multiplied alpha
        abstract premultiplyAlpha: bool with get, set
        /// Global unique identifier for this BaseTexture
        abstract uid: string with get, set
        /// Used by automatic texture Garbage Collection, stores last GC tick when it was bound
        abstract touched: float with get, set
        /// Whether or not the texture is a power of two, try to use power of two textures as much
        /// as you can
        abstract isPowerOfTwo: bool
        /// Used by TextureSystem to only update texture to the GPU when needed.
        /// Please call `update()` to increment it.
        abstract dirtyId: float
        /// Used by TextureSystem to only update texture style when needed.
        abstract dirtyStyleId: float with get, set
        /// Currently default cache ID.
        abstract cacheId: string with get, set
        /// Generally speaking means when resource is loaded.
        abstract valid: bool
        /// The collection of alternative cache ids, since some BaseTextures
        /// can have more than one ID, short name and longer full URL
        abstract textureCacheIds: ResizeArray<string>
        /// Flag if BaseTexture has been destroyed.
        abstract destroyed: bool
        /// The resource used by this BaseTexture, there can only
        /// be one resource per BaseTexture, but textures can share
        /// resources.
        abstract resource: PIXI.Resources.Resource
        /// Number of the texture batch, used by multi-texture renderers
        abstract _batchEnabled: float with get, set
        /// Pixel width of the source of this texture
        abstract realWidth: float
        /// Pixel height of the source of this texture
        abstract realHeight: float
        /// <summary>Changes style options of BaseTexture</summary>
        /// <param name="scaleMode">- Pixi scalemode</param>
        /// <param name="mipmap">- enable mipmaps</param>
        abstract setStyle: ?scaleMode: PIXI.SCALE_MODES * ?mipmap: PIXI.MIPMAP_MODES -> PIXI.BaseTexture
        /// <summary>Changes w/h/resolution. Texture becomes valid if width and height are greater than zero.</summary>
        /// <param name="width">Visual width</param>
        /// <param name="height">Visual height</param>
        /// <param name="resolution">Optionally set resolution</param>
        abstract setSize: width: float * height: float * ?resolution: float -> PIXI.BaseTexture
        /// <summary>Sets real size of baseTexture, preserves current resolution.</summary>
        /// <param name="realWidth">Full rendered width</param>
        /// <param name="realHeight">Full rendered height</param>
        /// <param name="resolution">Optionally set resolution</param>
        abstract setRealSize: realWidth: float * realHeight: float * ?resolution: float -> PIXI.BaseTexture
        /// <summary>Changes resolution</summary>
        /// <param name="resolution">res</param>
        abstract setResolution: ?resolution: float -> PIXI.BaseTexture
        /// <summary>Sets the resource if it wasn't set. Throws error if resource already present</summary>
        /// <param name="resource">- that is managing this BaseTexture</param>
        abstract setResource: resource: PIXI.Resources.Resource -> PIXI.BaseTexture
        /// Invalidates the object. Texture becomes valid if width and height are greater than zero.
        abstract update: unit -> unit
        /// Destroys this base texture.
        /// The method stops if resource doesn't want this texture to be destroyed.
        /// Removes texture from all caches.
        abstract destroy: unit -> unit
        /// Frees the texture from WebGL memory without destroying this texture object.
        /// This means you can still use the texture later which will upload it to GPU
        /// memory again.
        abstract dispose: unit -> unit

    /// A Texture that depends on six other resources.
    type [<AllowNullLiteral>] CubeTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CubeTexture
        abstract from: resources: U5<string, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.SVGElement, Browser.Types.HTMLVideoElement> * ?options: obj -> BaseTexture
        /// <summary>Generate a new CubeTexture.</summary>
        /// <param name="resources">- Collection of 6 URLs or resources</param>
        /// <param name="options">- Optional options passed to the resources being loaded.
        /// See {</param>
        abstract from: resources: U2<ResizeArray<string>, ResizeArray<PIXI.Resources.Resource>> * ?options: obj -> PIXI.CubeTexture

    /// Internal texture for WebGL context
    type [<AllowNullLiteral>] GLTexture =
        /// The WebGL texture
        // TODO abstract texture: WebGLTexture with get, set
        /// Width of texture that was used in texImage2D
        abstract width: float with get, set
        /// Height of texture that was used in texImage2D
        abstract height: float with get, set
        /// Texture contents dirty flag
        abstract dirtyId: float with get, set
        /// Texture style dirty flag
        abstract dirtyStyleId: float with get, set
        /// Whether mip levels has to be generated
        abstract mipmap: bool with get, set
        /// WrapMode copied from baseTexture
        abstract wrapMode: float with get, set

    /// Internal texture for WebGL context
    type [<AllowNullLiteral>] GLTextureStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GLTexture

    module Resources =

        type [<AllowNullLiteral>] IExports =
            abstract ArrayResource: ArrayResourceStatic
            abstract INSTALLED: ResizeArray<obj option>
            /// <summary>Create a resource element from a single source element. This
            /// auto-detects which type of resource to create. All resources that
            /// are auto-detectable must have a static `test` method and a constructor
            /// with the arguments `(source, options?)`. Currently, the supported
            /// resources for auto-detection include:
            ///   - {@link PIXI.resources.ImageResource}
            ///   - {@link PIXI.resources.CanvasResource}
            ///   - {@link PIXI.resources.VideoResource}
            ///   - {@link PIXI.resources.SVGResource}
            ///   - {@link PIXI.resources.BufferResource}</summary>
            /// <param name="source">- Resource source, this can be the URL to the resource,
            /// a typed-array (for BufferResource), Browser.Types.HTMLVideoElement, SVG data-uri
            /// or any other resource that can be auto-detected. If not resource is
            /// detected, it's assumed to be an ImageResource.</param>
            /// <param name="options">- Video option to update how many times a second the
            /// texture should be updated from the video. Leave at 0 to update at every render</param>
            abstract autoDetectResource: source: U2<string, obj option> * ?options: AutoDetectResourceOptions -> PIXI.Resources.Resource
            abstract BaseImageResource: BaseImageResourceStatic
            abstract BufferResource: BufferResourceStatic
            abstract CanvasResource: CanvasResourceStatic
            abstract CubeResource: CubeResourceStatic
            abstract DepthResource: DepthResourceStatic
            abstract ImageResource: ImageResourceStatic
            abstract Resource: ResourceStatic
            abstract SVGResource: SVGResourceStatic
            abstract VideoResource: VideoResourceStatic

        type [<AllowNullLiteral>] AutoDetectResourceOptions =
            abstract width: float option with get, set
            abstract height: float option with get, set
            abstract autoLoad: bool option with get, set
            abstract scale: float option with get, set
            abstract createBitmap: bool option with get, set
            abstract crossorigin: bool option with get, set
            abstract autoPlay: bool option with get, set
            abstract updateFPS: float option with get, set

        /// A resource that contains a number of sources.
        type [<AllowNullLiteral>] ArrayResource =
            inherit PIXI.Resources.Resource
            /// Collection of resources.
            abstract items: ResizeArray<PIXI.BaseTexture>
            /// Dirty IDs for each part
            abstract itemDirtyIds: ResizeArray<float>
            /// Number of elements in array
            abstract length: float
            /// <summary>Set a resource by ID</summary>
            /// <param name="resource"></param>
            /// <param name="index">- Zero-based index of resource to set</param>
            abstract addResourceAt: resource: PIXI.Resources.Resource * index: float -> PIXI.Resources.ArrayResource
            /// <summary>Upload the resources to the GPU.</summary>
            /// <param name="renderer"></param>
            /// <param name="texture"></param>
            /// <param name="glTexture"></param>
            abstract upload: renderer: PIXI.Renderer * texture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// Has been updated trigger event
            abstract update: unit -> unit
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// A resource that contains a number of sources.
        type [<AllowNullLiteral>] ArrayResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: U2<float, ResizeArray<obj option>> * ?options: ArrayResourceStaticOptions -> ArrayResource

        type [<AllowNullLiteral>] ArrayResourceStaticOptions =
            abstract width: float option with get, set
            abstract height: float option with get, set

        /// Base for all the image/canvas resources
        type [<AllowNullLiteral>] BaseImageResource =
            inherit PIXI.Resources.Resource
            /// The source element
            abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
            /// <summary>Upload the texture to the GPU.</summary>
            /// <param name="renderer">Upload to the renderer</param>
            /// <param name="baseTexture">Reference to parent texture</param>
            /// <param name="glTexture"></param>
            /// <param name="source">(optional)</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture * ?source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement> -> bool
            /// Checks if source width/height was changed, resize can cause extra baseTexture update.
            /// Triggers one update in any case.
            abstract update: unit -> unit
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Base for all the image/canvas resources
        type [<AllowNullLiteral>] BaseImageResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement> -> BaseImageResource
            /// <summary>Set cross origin based detecting the url and the crossorigin</summary>
            /// <param name="element">- Element to apply crossOrigin</param>
            /// <param name="url">- URL to check</param>
            /// <param name="crossorigin">- Cross origin value to use</param>
            abstract crossOrigin: element: Browser.Types.HTMLElement * url: string * ?crossorigin: U2<bool, string> -> unit

        /// Buffer resource with data of typed array.
        type [<AllowNullLiteral>] BufferResource =
            inherit PIXI.Resources.Resource
            /// Source array
            /// Cannot be ClampedUint8Array because it cant be uploaded to WebGL
            //abstract data: float [] with get, set
            abstract data: int [] with get, set
            /// <summary>Upload the texture to the GPU.</summary>
            /// <param name="renderer">Upload to the renderer</param>
            /// <param name="baseTexture">Reference to parent texture</param>
            /// <param name="glTexture">glTexture</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// Has been updated trigger event
            abstract update: unit -> unit
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Buffer resource with data of typed array.
        type [<AllowNullLiteral>] BufferResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: float [] * options: BufferResourceStaticOptions -> BufferResource
            [<Emit "new $0($1...)">] abstract Create: source: int [] * options: BufferResourceStaticOptions -> BufferResource
            /// <summary>Used to auto-detect the type of resource.</summary>
            /// <param name="source">- The source object</param>
            abstract test: source: obj option -> bool

        type [<AllowNullLiteral>] BufferResourceStaticOptions =
            abstract width: float with get, set
            abstract height: float with get, set

        /// Resource type for Browser.Types.HTMLCanvasElement.
        type [<AllowNullLiteral>] CanvasResource =
            inherit PIXI.Resources.BaseImageResource
            /// The source element
            //abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
            abstract source: Browser.Types.HTMLImageElement with get
            //abstract source: Browser.Types.HTMLCanvasElement with get 
            //abstract source: Browser.Types.HTMLVideoElement with get

            //abstract source: Browser.Types.SVGElement
            /// <summary>Upload the texture to the GPU.</summary>
            /// <param name="renderer">Upload to the renderer</param>
            /// <param name="baseTexture">Reference to parent texture</param>
            /// <param name="glTexture"></param>
            /// <param name="source">(optional)</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture * ?source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement> -> bool
            /// Checks if source width/height was changed, resize can cause extra baseTexture update.
            /// Triggers one update in any case.
            abstract update: unit -> unit
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Resource type for Browser.Types.HTMLCanvasElement.
        type [<AllowNullLiteral>] CanvasResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: Browser.Types.HTMLCanvasElement -> CanvasResource
            /// <summary>Used to auto-detect the type of resource.</summary>
            /// <param name="source">- The source object</param>
            //abstract test: source: U2<Browser.Types.HTMLCanvasElement, OffscreenCanvas> -> bool
            abstract test: source: Browser.Types.HTMLCanvasElement -> bool

        /// Resource for a CubeTexture which contains six resources.
        type [<AllowNullLiteral>] CubeResource =
            inherit PIXI.Resources.ArrayResource
            /// Upload the resource
            abstract upload: unit -> bool
            /// Collection of resources.
            abstract items: ResizeArray<PIXI.BaseTexture>
            /// Dirty IDs for each part
            abstract itemDirtyIds: ResizeArray<float>
            /// Number of elements in array
            abstract length: float
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// <summary>Set a resource by ID</summary>
            /// <param name="resource"></param>
            /// <param name="index">- Zero-based index of resource to set</param>
            abstract addResourceAt: resource: PIXI.Resources.Resource * index: float -> PIXI.Resources.ArrayResource
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// Has been updated trigger event
            abstract update: unit -> unit
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Resource for a CubeTexture which contains six resources.
        type [<AllowNullLiteral>] CubeResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: ?source: ResizeArray<U2<string, PIXI.Resources.Resource>> * ?options: CubeResourceStaticOptions -> CubeResource
            /// Number of texture sides to store for CubeResources
            abstract SIDES: float with get, set

        type [<AllowNullLiteral>] CubeResourceStaticOptions =
            abstract width: float option with get, set
            abstract height: float option with get, set

        /// Resource type for DepthTexture.
        type [<AllowNullLiteral>] DepthResource =
            inherit PIXI.Resources.BufferResource
            /// <summary>Upload the texture to the GPU.</summary>
            /// <param name="renderer">Upload to the renderer</param>
            /// <param name="baseTexture">Reference to parent texture</param>
            /// <param name="glTexture">glTexture</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Source array
            /// Cannot be ClampedUint8Array because it cant be uploaded to WebGL
            abstract data: float [] with get, set
            //abstract data: int [] with get, set
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// Has been updated trigger event
            abstract update: unit -> unit
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Resource type for DepthTexture.
        type [<AllowNullLiteral>] DepthResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> DepthResource

        /// Resource type for Browser.Types.HTMLImageElement.
        type [<AllowNullLiteral>] ImageResource =
            inherit PIXI.Resources.BaseImageResource
            /// URL of the image source
            abstract url: string with get, set
            /// If the image should be disposed after upload
            abstract preserveBitmap: bool with get, set
            /// If capable, convert the image using createImageBitmap API
            abstract createBitmap: bool with get, set
            /// Controls texture premultiplyAlpha field
            /// Copies from options
            abstract premultiplyAlpha: bool option
            /// The ImageBitmap element created for Browser.Types.HTMLImageElement
            // TODO abstract bitmap: ImageBitmap with get, set
            /// <summary>returns a JS.Promise when image will be loaded and processed</summary>
            /// <param name="createBitmap">whether process image into bitmap</param>
            abstract load: ?createBitmap: bool -> JS.Promise<unit>
            /// Called when we need to convert image into BitmapImage.
            /// Can be called multiple times, real JS.Promise is cached inside.
            abstract ``process``: unit -> JS.Promise<unit>
            /// <summary>Upload the image resource to GPU.</summary>
            /// <param name="renderer">- Renderer to upload to</param>
            /// <param name="baseTexture">- BaseTexture for this resource</param>
            /// <param name="glTexture">- GLTexture to use</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// The source element
            abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
            /// Checks if source width/height was changed, resize can cause extra baseTexture update.
            /// Triggers one update in any case.
            abstract update: unit -> unit
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Resource type for Browser.Types.HTMLImageElement.
        type [<AllowNullLiteral>] ImageResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: U2<Browser.Types.HTMLImageElement, string> -> ImageResource

        /// Base resource class for textures that manages validation and uploading, depending on its type.
        /// 
        /// Uploading of a base texture to the GPU is required.
        type [<AllowNullLiteral>] Resource =
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// Has been updated trigger event
            abstract update: unit -> unit
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Uploads the texture or returns false if it cant for some reason. Override this.</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Base resource class for textures that manages validation and uploading, depending on its type.
        /// 
        /// Uploading of a base texture to the GPU is required.
        type [<AllowNullLiteral>] ResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: ?width: float * ?height: float -> Resource

        /// Resource type for SVG elements and graphics.
        type [<AllowNullLiteral>] SVGResource =
            inherit PIXI.Resources.BaseImageResource
            /// Base64 encoded SVG element or URL for SVG file
            abstract svg: string
            /// The source scale to apply to render
            abstract scale: float
            /// The source element
            abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
            /// <summary>Upload the texture to the GPU.</summary>
            /// <param name="renderer">Upload to the renderer</param>
            /// <param name="baseTexture">Reference to parent texture</param>
            /// <param name="glTexture"></param>
            /// <param name="source">(optional)</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture * ?source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement> -> bool
            /// Checks if source width/height was changed, resize can cause extra baseTexture update.
            /// Triggers one update in any case.
            abstract update: unit -> unit
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// This can be overridden to start preloading a resource
            /// or do any other prepare step.
            abstract load: unit -> JS.Promise<unit>
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Resource type for SVG elements and graphics.
        type [<AllowNullLiteral>] SVGResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: string * ?options: SVGResourceStaticOptions -> SVGResource
            /// <summary>Get size from an svg string using regexp.</summary>
            /// <param name="svgString">- a serialized svg element</param>
            abstract getSize: svgString: string -> PIXI.Resources.SVGResource.Size
            /// <summary>Used to auto-detect the type of resource.</summary>
            /// <param name="source">- The source object</param>
            /// <param name="extension">- The extension of source, if set</param>
            abstract test: source: obj option * extension: string -> unit
            /// RegExp for SVG size.
            // TODO abstract SVG_SIZE: U2<RegExp, string>

        type [<AllowNullLiteral>] SVGResourceStaticOptions =
            abstract scale: float option with get, set
            abstract autoLoad: bool option with get, set

        module SVGResource =

            type [<AllowNullLiteral>] Size =
                abstract width: float with get, set
                abstract height: float with get, set

        /// Resource type for Browser.Types.HTMLVideoElement.
        type [<AllowNullLiteral>] VideoResource =
            inherit PIXI.Resources.BaseImageResource
            /// When set to true will automatically play videos used by this texture once
            /// they are loaded. If false, it will not modify the playing state.
            abstract autoPlay: bool with get, set
            /// <summary>Trigger updating of the texture</summary>
            /// <param name="deltaTime">- time delta since last tick</param>
            abstract update: ?deltaTime: float -> unit
            /// Start preloading the video resource.
            abstract load: unit -> JS.Promise<unit>
            /// Should the base texture automatically update itself, set to true by default
            abstract autoUpdate: bool with get, set
            /// How many times a second to update the texture from the video. Leave at 0 to update at every render.
            /// A lower fps can help performance, as updating the texture at 60fps on a 30ps video may not be efficient.
            abstract updateFPS: float with get, set
            /// The source element
            abstract source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement>
            /// <summary>Upload the texture to the GPU.</summary>
            /// <param name="renderer">Upload to the renderer</param>
            /// <param name="baseTexture">Reference to parent texture</param>
            /// <param name="glTexture"></param>
            /// <param name="source">(optional)</param>
            abstract upload: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture * ?source: U4<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, Browser.Types.SVGElement> -> bool
            /// Clean up anything, this happens when destroying is ready.
            abstract dispose: unit -> unit
            /// Internal width of the resource
            abstract _width: float with get, set
            /// Internal height of the resource
            abstract _height: float with get, set
            /// If resource has been destroyed
            abstract destroyed: bool
            /// `true` if resource is created by BaseTexture
            /// useful for doing cleanup with BaseTexture destroy
            /// and not cleaning up resources that were created
            /// externally.
            abstract ``internal``: bool with get, set
            /// <summary>Bind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract bind: baseTexture: PIXI.BaseTexture -> unit
            /// <summary>Unbind to a parent BaseTexture</summary>
            /// <param name="baseTexture">- Parent texture</param>
            abstract unbind: baseTexture: PIXI.BaseTexture -> unit
            /// Trigger a resize event
            abstract resize: unit -> unit
            /// Has been validated
            abstract valid: bool
            /// The width of the resource.
            abstract width: float
            /// The height of the resource.
            abstract height: float
            /// <summary>Set the style, optional to override</summary>
            /// <param name="renderer">- yeah, renderer!</param>
            /// <param name="baseTexture">- the texture</param>
            /// <param name="glTexture">- texture instance for this webgl context</param>
            abstract style: renderer: PIXI.Renderer * baseTexture: PIXI.BaseTexture * glTexture: PIXI.GLTexture -> bool
            /// Call when destroying resource, unbind any BaseTexture object
            /// before calling this method, as reference counts are maintained
            /// internally.
            abstract destroy: unit -> unit

        /// Resource type for Browser.Types.HTMLVideoElement.
        type [<AllowNullLiteral>] VideoResourceStatic =
            [<Emit "new $0($1...)">] abstract Create: source: U4<Browser.Types.HTMLVideoElement, obj option, string, ResizeArray<U2<string, obj option>>> * ?options: VideoResourceStaticOptions -> VideoResource
            /// <summary>Used to auto-detect the type of resource.</summary>
            /// <param name="source">- The source object</param>
            /// <param name="extension">- The extension of source, if set</param>
            abstract test: source: obj option * extension: string -> bool
            /// List of common video file extensions supported by VideoResource.
            abstract TYPES: ResizeArray<string>

        type [<AllowNullLiteral>] VideoResourceStaticOptions =
            abstract autoLoad: bool option with get, set
            abstract autoPlay: bool option with get, set
            abstract updateFPS: float option with get, set
            abstract crossorigin: bool option with get, set

    /// A texture stores the information that represents an image or part of an image.
    /// 
    /// It cannot be added to the display list directly; instead use it as the texture for a Sprite.
    /// If no frame is provided for a texture, then the whole image is used.
    /// 
    /// You can directly create a texture from an image and then reuse it multiple times like this :
    /// 
    /// ```js
    /// let texture = PIXI.Texture.from('assets/image.png');
    /// let sprite1 = new PIXI.Sprite(texture);
    /// let sprite2 = new PIXI.Sprite(texture);
    /// ```
    /// 
    /// If you didnt pass the texture frame to constructor, it enables `noFrame` mode:
    /// it subscribes on baseTexture events, it automatically resizes at the same time as baseTexture.
    /// 
    /// Textures made from SVGs, loaded or not, cannot be used before the file finishes processing.
    /// You can check for this by checking the sprite's _textureID property.
    /// ```js
    /// var texture = PIXI.Texture.from('assets/image.svg');
    /// var sprite1 = new PIXI.Sprite(texture);
    /// //sprite1._textureID should not be undefined if the texture has finished processing the SVG file
    /// ```
    /// You can use a ticker or rAF to ensure your sprites load the finished textures after processing. See issue #3068.
    type [<AllowNullLiteral>] Texture =
        inherit PIXI.Utils.EventEmitter
        /// Does this Texture have any frame data assigned to it?
        /// 
        /// This mode is enabled automatically if no frame was passed inside constructor.
        /// 
        /// In this mode texture is subscribed to baseTexture events, and fires `update` on any change.
        /// 
        /// Beware, after loading or resize of baseTexture event can fired two times!
        /// If you want more control, subscribe on baseTexture itself.
        /// 
        /// ```js
        /// texture.on('update', () => {});
        /// ```
        /// 
        /// Any assignment of `frame` switches off `noFrame` mode.
        abstract noFrame: bool with get, set
        /// The base texture that this texture uses.
        abstract baseTexture: PIXI.BaseTexture with get, set
        /// This is the area of the BaseTexture image to actually copy to the Canvas / WebGL when rendering,
        /// irrespective of the actual frame size or placement (which can be influenced by trimmed texture atlases)
        abstract _frame: PIXI.Rectangle with get, set
        /// This is the trimmed area of original texture, before it was put in atlas
        /// Please call `updateUvs()` after you change coordinates of `trim` manually.
        abstract trim: PIXI.Rectangle with get, set
        /// This will let the renderer know if the texture is valid. If it's not then it cannot be rendered.
        abstract valid: bool with get, set
        /// This will let a renderer know that a texture has been updated (used mainly for WebGL uv updates)
        abstract requiresUpdate: bool with get, set
        /// The WebGL UV data cache. Can be used as quad UV
        abstract _uvs: PIXI.TextureUvs with get, set
        /// Default TextureMatrix instance for this texture
        /// By default that object is not created because its heavy
        abstract uvMatrix: PIXI.TextureMatrix with get, set
        /// This is the area of original texture, before it was put in atlas
        abstract orig: PIXI.Rectangle with get, set
        /// Anchor point that is used as default if sprite is created with this texture.
        /// Changing the `defaultAnchor` at a later point of time will not update Sprite's anchor point.
        abstract defaultAnchor: PIXI.Point with get, set
        /// Update ID is observed by sprites and TextureMatrix instances.
        /// Call updateUvs() to increment it.
        abstract _updateID: float with get, set
        /// The ids under which this Texture has been added to the texture cache. This is
        /// automatically set as long as Texture.addToCache is used, but may not be set if a
        /// Texture is added directly to the TextureCache array.
        abstract textureCacheIds: ResizeArray<string> with get, set
        /// Updates this texture on the gpu.
        /// 
        /// Calls the TextureResource update.
        /// 
        /// If you adjusted `frame` manually, please call `updateUvs()` instead.
        abstract update: unit -> unit
        /// <summary>Called when the base texture is updated</summary>
        /// <param name="baseTexture">- The base texture.</param>
        abstract onBaseTextureUpdated: baseTexture: PIXI.BaseTexture -> unit
        /// <summary>Destroys this texture</summary>
        /// <param name="destroyBase">Whether to destroy the base texture as well</param>
        abstract destroy: ?destroyBase: bool -> unit
        /// Creates a new texture object that acts the same as this one.
        abstract clone: unit -> PIXI.Texture
        /// Updates the internal WebGL UV cache. Use it after you change `frame` or `trim` of the texture.
        /// Call it after changing the frame
        abstract updateUvs: unit -> unit
        /// The frame specifies the region of the base texture that this texture uses.
        /// Please call `updateUvs()` after you change coordinates of `frame` manually.
        abstract frame: PIXI.Rectangle with get, set
        /// Indicates whether the texture is rotated inside the atlas
        /// set to 2 to compensate for texture packer rotation
        /// set to 6 to compensate for spine packer rotation
        /// can be used to rotate or mirror sprites
        /// See {@link PIXI.GroupD8} for explanation
        abstract rotate: float with get, set
        /// The width of the Texture in pixels.
        abstract width: float with get, set
        /// The height of the Texture in pixels.
        abstract height: float with get, set

    /// A texture stores the information that represents an image or part of an image.
    /// 
    /// It cannot be added to the display list directly; instead use it as the texture for a Sprite.
    /// If no frame is provided for a texture, then the whole image is used.
    /// 
    /// You can directly create a texture from an image and then reuse it multiple times like this :
    /// 
    /// ```js
    /// let texture = PIXI.Texture.from('assets/image.png');
    /// let sprite1 = new PIXI.Sprite(texture);
    /// let sprite2 = new PIXI.Sprite(texture);
    /// ```
    /// 
    /// If you didnt pass the texture frame to constructor, it enables `noFrame` mode:
    /// it subscribes on baseTexture events, it automatically resizes at the same time as baseTexture.
    /// 
    /// Textures made from SVGs, loaded or not, cannot be used before the file finishes processing.
    /// You can check for this by checking the sprite's _textureID property.
    /// ```js
    /// var texture = PIXI.Texture.from('assets/image.svg');
    /// var sprite1 = new PIXI.Sprite(texture);
    /// //sprite1._textureID should not be undefined if the texture has finished processing the SVG file
    /// ```
    /// You can use a ticker or rAF to ensure your sprites load the finished textures after processing. See issue #3068.
    type [<AllowNullLiteral>] TextureStatic =
        [<Emit "new $0($1...)">] abstract Create: baseTexture: PIXI.BaseTexture * ?frame: PIXI.Rectangle * ?orig: PIXI.Rectangle * ?trim: PIXI.Rectangle * ?rotate: float * ?anchor: PIXI.Point -> Texture
        abstract fromImage: unit -> PIXI.Texture
        abstract fromSVG: unit -> PIXI.Texture
        abstract fromCanvas: unit -> PIXI.Texture
        abstract fromVideo: unit -> PIXI.Texture
        abstract fromFrame: unit -> PIXI.Texture
        /// <summary>Helper function that creates a new Texture based on the source you provide.
        /// The source can be - frame id, image url, video url, canvas element, video element, base texture</summary>
        /// <param name="source">Source to create texture from</param>
        /// <param name="options">See {</param>
        abstract from: source: U6<float, string, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, PIXI.BaseTexture> * ?options: obj -> PIXI.Texture
        /// <summary>Create a new Texture with a BufferResource from a float [].
        /// RGBA values are floats from 0 to 1.</summary>
        /// <param name="buffer">The optional array to use, if no data
        /// is provided, a new float [] is created.</param>
        /// <param name="width">- Width of the resource</param>
        /// <param name="height">- Height of the resource</param>
        /// <param name="options">See {</param>
        abstract fromBuffer: buffer: float [] * width: float * height: float * ?options: obj -> PIXI.Texture
        abstract fromBuffer: buffer: int[] * width: float * height: float * ?options: obj -> PIXI.Texture
        /// <summary>Create a texture from a source and add to the cache.</summary>
        /// <param name="source">- The input source.</param>
        /// <param name="imageUrl">- File name of texture, for cache and resolving resolution.</param>
        /// <param name="name">- Human readable name for the texture cache. If no name is
        /// specified, only `imageUrl` will be used as the cache ID.</param>
        abstract fromLoader: source: U2<Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement> * imageUrl: string * ?name: string -> PIXI.Texture
        /// <summary>Adds a Texture to the global TextureCache. This cache is shared across the whole PIXI object.</summary>
        /// <param name="texture">- The Texture to add to the cache.</param>
        /// <param name="id">- The id that the Texture will be stored against.</param>
        abstract addToCache: texture: PIXI.Texture * id: string -> unit
        /// <summary>Remove a Texture from the global TextureCache.</summary>
        /// <param name="texture">- id of a Texture to be removed, or a Texture instance itself</param>
        abstract removeFromCache: texture: U2<string, PIXI.Texture> -> PIXI.Texture option
        /// An empty texture, used often to not have to create multiple empty textures.
        /// Can not be destroyed.
        abstract EMPTY: PIXI.Texture with get, set
        /// A white texture of 10x10 size, used for graphics and other things
        /// Can not be destroyed.
        abstract WHITE: PIXI.Texture with get, set

    /// Class controls uv mapping from Texture normal space to BaseTexture normal space.
    /// 
    /// Takes `trim` and `rotate` into account. May contain clamp settings for Meshes and TilingSprite.
    /// 
    /// Can be used in Texture `uvMatrix` field, or separately, you can use different clamp settings on the same texture.
    /// If you want to add support for texture region of certain feature or filter, that's what you're looking for.
    /// 
    /// Takes track of Texture changes through `_lastTextureID` private field.
    /// Use `update()` method call to track it from outside.
    type [<AllowNullLiteral>] TextureMatrix =
        /// Tracks Texture frame changes
        abstract _updateID: float with get, set
        /// Changes frame clamping
        /// Works with TilingSprite and Mesh
        /// Change to 1.5 if you texture has repeated right and bottom lines, that leads to smoother borders
        abstract clampOffset: float with get, set
        /// Changes frame clamping
        /// Works with TilingSprite and Mesh
        /// Change to -0.5 to add a pixel to the edge, recommended for transparent trimmed textures in atlas
        abstract clampMargin: float with get, set
        /// If texture size is the same as baseTexture
        abstract isSimple: bool
        /// texture property
        abstract texture: PIXI.Texture with get, set
        /// <summary>Multiplies uvs array to transform</summary>
        /// <param name="uvs">mesh uvs</param>
        /// <param name="out">output</param>
        abstract multiplyUvs: uvs: float [] * ?out: float [] -> float []
        /// <summary>updates matrices if texture was changed</summary>
        /// <param name="forceUpdate">if true, matrices will be updated any case</param>
        abstract update: ?forceUpdate: bool -> bool

    /// Class controls uv mapping from Texture normal space to BaseTexture normal space.
    /// 
    /// Takes `trim` and `rotate` into account. May contain clamp settings for Meshes and TilingSprite.
    /// 
    /// Can be used in Texture `uvMatrix` field, or separately, you can use different clamp settings on the same texture.
    /// If you want to add support for texture region of certain feature or filter, that's what you're looking for.
    /// 
    /// Takes track of Texture changes through `_lastTextureID` private field.
    /// Use `update()` method call to track it from outside.
    type [<AllowNullLiteral>] TextureMatrixStatic =
        [<Emit "new $0($1...)">] abstract Create: texture: PIXI.Texture * ?clampMargin: float -> TextureMatrix

    /// A standard object to store the Uvs of a texture
    type [<AllowNullLiteral>] TextureUvs =
        /// <summary>Sets the texture Uvs based on the given frame information.</summary>
        /// <param name="frame">- The frame of the texture</param>
        /// <param name="baseFrame">- The base frame of the texture</param>
        /// <param name="rotate">- Rotation of frame, see {</param>
        abstract set: frame: PIXI.Rectangle * baseFrame: PIXI.Rectangle * rotate: float -> unit

    /// A standard object to store the Uvs of a texture
    type [<AllowNullLiteral>] TextureUvsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextureUvs

    /// Helper class to create a quad
    type [<AllowNullLiteral>] Quad =
        interface end

    /// Helper class to create a quad
    type [<AllowNullLiteral>] QuadStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Quad

    /// Helper class to create a quad with uvs like in v4
    type [<AllowNullLiteral>] QuadUv =
        /// An array of vertices
        abstract vertices: float [] with get, set
        /// The Uvs of the quad
        abstract uvs: float [] with get, set
        /// <summary>Maps two Rectangle to the quad.</summary>
        /// <param name="targetTextureFrame">- the first rectangle</param>
        /// <param name="destinationFrame">- the second rectangle</param>
        abstract map: targetTextureFrame: PIXI.Rectangle * destinationFrame: PIXI.Rectangle -> PIXI.Quad
        /// legacy upload method, just marks buffers dirty
        abstract invalidate: unit -> PIXI.QuadUv

    /// Helper class to create a quad with uvs like in v4
    type [<AllowNullLiteral>] QuadUvStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> QuadUv

    /// 'Builder' pattern for bounds rectangles.
    /// 
    /// This could be called an Axis-Aligned Bounding Box.
    /// It is not an actual shape. It is a mutable thing; no 'EMPTY' or those kind of problems.
    type [<AllowNullLiteral>] Bounds =
        abstract minX: float with get, set
        abstract minY: float with get, set
        abstract maxX: float with get, set
        abstract maxY: float with get, set
        /// Checks if bounds are empty.
        abstract isEmpty: unit -> bool
        /// Clears the bounds and resets.
        abstract clear: unit -> unit
        /// <summary>Can return Rectangle.EMPTY constant, either construct new rectangle, either use your rectangle
        /// It is not guaranteed that it will return tempRect</summary>
        /// <param name="rect">- temporary object will be used if AABB is not empty</param>
        abstract getRectangle: rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>This function should be inlined when its possible.</summary>
        /// <param name="point">- The point to add.</param>
        abstract addPoint: point: PIXI.Point -> unit
        /// <summary>Adds a quad, not transformed</summary>
        /// <param name="vertices">- The verts to add.</param>
        abstract addQuad: vertices: float [] -> unit
        /// <summary>Adds sprite frame, transformed.</summary>
        /// <param name="transform">- TODO</param>
        /// <param name="x0">- TODO</param>
        /// <param name="y0">- TODO</param>
        /// <param name="x1">- TODO</param>
        /// <param name="y1">- TODO</param>
        abstract addFrame: transform: PIXI.Transform * x0: float * y0: float * x1: float * y1: float -> unit
        /// <summary>Adds screen vertices from array</summary>
        /// <param name="vertexData">- calculated vertices</param>
        /// <param name="beginOffset">- begin offset</param>
        /// <param name="endOffset">- end offset, excluded</param>
        abstract addVertexData: vertexData: float [] * beginOffset: float * endOffset: float -> unit
        /// <summary>Add an array of mesh vertices</summary>
        /// <param name="transform">- mesh transform</param>
        /// <param name="vertices">- mesh coordinates in array</param>
        /// <param name="beginOffset">- begin offset</param>
        /// <param name="endOffset">- end offset, excluded</param>
        abstract addVertices: transform: PIXI.Transform * vertices: float [] * beginOffset: float * endOffset: float -> unit
        /// <summary>Adds other Bounds</summary>
        /// <param name="bounds">- TODO</param>
        abstract addBounds: bounds: PIXI.Bounds -> unit
        /// <summary>Adds other Bounds, masked with Bounds</summary>
        /// <param name="bounds">- TODO</param>
        /// <param name="mask">- TODO</param>
        abstract addBoundsMask: bounds: PIXI.Bounds * mask: PIXI.Bounds -> unit
        /// <summary>Adds other Bounds, masked with Rectangle</summary>
        /// <param name="bounds">- TODO</param>
        /// <param name="area">- TODO</param>
        abstract addBoundsArea: bounds: PIXI.Bounds * area: PIXI.Rectangle -> unit

    /// 'Builder' pattern for bounds rectangles.
    /// 
    /// This could be called an Axis-Aligned Bounding Box.
    /// It is not an actual shape. It is a mutable thing; no 'EMPTY' or those kind of problems.
    type [<AllowNullLiteral>] BoundsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Bounds

    /// A Container represents a collection of display objects.
    /// 
    /// It is the base class of all display objects that act as a container for other objects (like Sprites).
    /// 
    /// ```js
    /// let container = new PIXI.Container();
    /// container.addChild(sprite);
    /// ```
    type [<AllowNullLiteral>] Container =
        inherit PIXI.DisplayObject
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        abstract addChild: child: PIXI.DisplayObject -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// Recalculates the bounds of the object. Override this to
        /// calculate the bounds of the specific object (not including children).
        abstract _calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// <summary>To be overridden by the subclasses.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// <summary>Removes all internal references and listeners as well as removes children from the display list.
        /// Do not use a Container after calling `destroy`.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?options: ContainerDestroyOptions -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point
        abstract once: ``event``: string * fn: (DisplayObject -> unit) * ?context: obj -> Container
        abstract once: ``event``: string * fn: (unit -> unit) * ?context: obj -> Container
        abstract on: ``event``: string * fn: (DisplayObject -> unit) * ?context: obj -> Container
        abstract on: ``event``: string * fn: (unit->unit) * ?context: obj -> Container
        abstract off: ``event``: string * ?fn: (unit->unit) * ?context: obj -> Container

    type [<AllowNullLiteral>] ContainerDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// A Container represents a collection of display objects.
    /// 
    /// It is the base class of all display objects that act as a container for other objects (like Sprites).
    /// 
    /// ```js
    /// let container = new PIXI.Container();
    /// container.addChild(sprite);
    /// ```
    type [<AllowNullLiteral>] ContainerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Container

    /// The base class for all objects that are rendered on the screen.
    /// 
    /// This is an abstract class and should not be used on its own; rather it should be extended.
    type [<AllowNullLiteral>] DisplayObject =
        inherit PIXI.Utils.EventEmitter
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Updates the object transform for rendering.
        /// 
        /// TODO - Optimization pass!
        abstract updateTransform: unit -> unit
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Renders the object using the WebGL renderer.</summary>
        /// <param name="renderer">- The renderer.</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// Base destroy method for generic display objects. This will automatically
        /// remove the display object from its parent Container as well as remove
        /// all current event listeners and internal references. Do not use a DisplayObject
        /// after calling `destroy()`.
        abstract destroy: unit -> unit
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point
        abstract on: ``event``: Interaction.InteractionEventTypes * fn: (Interaction.InteractionEvent -> unit) * ?context: obj -> DisplayObject
        abstract once: ``event``: Interaction.InteractionEventTypes * fn: (Interaction.InteractionEvent -> unit) * ?context: obj -> DisplayObject
        abstract removeListener: ``event``: Interaction.InteractionEventTypes * ?fn: (Interaction.InteractionEvent -> unit) * ?context: obj -> DisplayObject
        abstract removeAllListeners: ?``event``: Interaction.InteractionEventTypes -> DisplayObject
        abstract off: ``event``: Interaction.InteractionEventTypes * ?fn: (Interaction.InteractionEvent -> unit) * ?context: obj -> DisplayObject
        abstract addListener: ``event``: Interaction.InteractionEventTypes * fn: (Interaction.InteractionEvent -> unit) * ?context: obj -> DisplayObject

    /// The base class for all objects that are rendered on the screen.
    /// 
    /// This is an abstract class and should not be used on its own; rather it should be extended.
    type [<AllowNullLiteral>] DisplayObjectStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DisplayObject
        /// <summary>Mixes all enumerable properties and methods from a source object to DisplayObject.</summary>
        /// <param name="source">The source of properties and methods to mix in.</param>
        abstract ``mixin``: source: obj option -> unit

    module Extract =

        type [<AllowNullLiteral>] IExports =
            abstract WebGLExtract: WebGLExtractStatic
            abstract Extract: ExtractStatic

        type [<AllowNullLiteral>] WebGLExtract =
            interface end

        type [<AllowNullLiteral>] WebGLExtractStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLExtract

        /// The extract manager provides functionality to export content from the renderers.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.extract`
        type [<AllowNullLiteral>] Extract =
            /// <summary>Will return a HTML Image of the target</summary>
            /// <param name="target">- A displayObject or renderTexture
            /// to convert. If left empty will use the main renderer</param>
            /// <param name="format">- Image format, e.g. "image/jpeg" or "image/webp".</param>
            /// <param name="quality">- JPEG or Webp compression from 0 to 1. Default is 0.92.</param>
            abstract image: target: U2<PIXI.DisplayObject, PIXI.RenderTexture> * ?format: string * ?quality: float -> Browser.Types.HTMLImageElement
            /// <summary>Will return a a base64 encoded string of this target. It works by calling
            ///   `Extract.getCanvas` and then running toDataURL on that.</summary>
            /// <param name="target">- A displayObject or renderTexture
            /// to convert. If left empty will use the main renderer</param>
            /// <param name="format">- Image format, e.g. "image/jpeg" or "image/webp".</param>
            /// <param name="quality">- JPEG or Webp compression from 0 to 1. Default is 0.92.</param>
            abstract base64: target: U2<PIXI.DisplayObject, PIXI.RenderTexture> * ?format: string * ?quality: float -> string
            /// <summary>Creates a Canvas element, renders this target to it and then returns it.</summary>
            /// <param name="target">- A displayObject or renderTexture
            /// to convert. If left empty will use the main renderer</param>
            abstract canvas: target: U2<PIXI.DisplayObject, PIXI.RenderTexture> -> Browser.Types.HTMLCanvasElement
            /// <summary>Will return a one-dimensional array containing the pixel data of the entire texture in RGBA
            /// order, with integer values between 0 and 255 (included).</summary>
            /// <param name="target">- A displayObject or renderTexture
            /// to convert. If left empty will use the main renderer</param>
            abstract pixels: target: PIXI.DisplayObject -> int [] //Uint8ClampedArray
            abstract pixels: target: PIXI.RenderTexture -> int [] //Uint8ClampedArray
            /// Destroys the extract
            abstract destroy: unit -> unit

        /// The extract manager provides functionality to export content from the renderers.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.extract`
        type [<AllowNullLiteral>] ExtractStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> Extract

    /// The Graphics class contains methods used to draw primitive shapes such as lines, circles and
    /// rectangles to the display, and to color and fill them.
    /// 
    /// Note that because Graphics can share a GraphicsGeometry with other instances,
    /// it is necessary to call `destroy()` to properly dereference the underlying
    /// GraphicsGeometry and avoid a memory leak. Alternatively, keep using the same
    /// Graphics instance and call `clear()` between redraws.
    type [<AllowNullLiteral>] Graphics =
        inherit PIXI.Container
        /// Includes vertex positions, face indices, normals, colors, UVs, and
        /// custom attributes within buffers, reducing the cost of passing all
        /// this data to the GPU. Can be shared between multiple Mesh or Graphics objects.
        abstract geometry: PIXI.GraphicsGeometry
        /// Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
        /// Can be shared between multiple Graphics objects.
        abstract shader: PIXI.Shader with get, set
        /// Represents the WebGL state the Graphics required to render, excludes shader and geometry. E.g.,
        /// blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
        abstract state: PIXI.State with get, set
        /// Current fill style
        abstract _fillStyle: PIXI.FillStyle with get, set
        /// Current line style
        abstract _lineStyle: PIXI.LineStyle with get, set
        /// Current shape transform matrix.
        abstract _matrix: PIXI.Matrix with get, set
        /// Current hole mode is enabled.
        abstract _holeMode: bool with get, set
        /// Current path
        abstract currentPath: PIXI.Polygon with get, set
        /// When cacheAsBitmap is set to true the graphics object will be rendered as if it was a sprite.
        /// This is useful if your graphics element does not change often, as it will speed up the rendering
        /// of the object in exchange for taking up texture memory. It is also useful if you need the graphics
        /// object to be anti-aliased, because it will be rendered using canvas. This is not recommended if
        /// you are constantly redrawing the graphics element.
        abstract cacheAsBitmap: bool with get, set
        /// A collections of batches! These can be drawn by the renderer batch system.
        abstract batches: ResizeArray<obj option> with get, set
        /// Update dirty for limiting calculating tints for batches.
        abstract batchTint: float with get, set
        /// Copy of the object vertex data.
        abstract vertexData: float [] with get, set
        /// Creates a new Graphics object with the same values as this one.
        /// Note that the only the properties of the object are cloned, not its transform (position,scale,etc)
        abstract clone: unit -> PIXI.Graphics
        /// The blend mode to be applied to the graphic shape. Apply a value of
        /// `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// The tint applied to the graphic shape. This is a hex value. A value of
        /// 0xFFFFFF will remove any tint effect.
        abstract tint: float with get, set
        /// The current fill style.
        abstract fill: PIXI.FillStyle
        /// The current line style.
        abstract line: PIXI.LineStyle
        /// <summary>Specifies the line style used for subsequent calls to Graphics methods such as the lineTo()
        /// method or the drawCircle() method.</summary>
        /// <param name="width">- width of the line to draw, will update the objects stored style</param>
        /// <param name="color">- color of the line to draw, will update the objects stored style</param>
        /// <param name="alpha">- alpha of the line to draw, will update the objects stored style</param>
        /// <param name="alignment">- alignment of the line to draw, (0 = inner, 0.5 = middle, 1 = outter)</param>
        /// <param name="native">- If true the lines will be draw using LINES instead of TRIANGLE_STRIP</param>
        abstract lineStyle: ?width: float * ?color: float * ?alpha: float * ?alignment: float * ?native: bool -> PIXI.Graphics
        /// <summary>Like line style but support texture for line fill.</summary>
        /// <param name="width">- width of the line to draw, will update the objects stored style</param>
        /// <param name="texture">- Texture to use</param>
        /// <param name="color">- color of the line to draw, will update the objects stored style</param>
        /// <param name="alpha">- alpha of the line to draw, will update the objects stored style</param>
        /// <param name="matrix">Texture matrix to transform texture</param>
        /// <param name="alignment">- alignment of the line to draw, (0 = inner, 0.5 = middle, 1 = outter)</param>
        /// <param name="native">- If true the lines will be draw using LINES instead of TRIANGLE_STRIP</param>
        abstract lineTextureStyle: ?width: float * ?texture: PIXI.Texture * ?color: float * ?alpha: float * ?matrix: PIXI.Matrix * ?alignment: float * ?native: bool -> PIXI.Graphics
        /// Start a polygon object internally
        abstract startPoly: unit -> unit
        /// Finish the polygon object.
        abstract finishPoly: unit -> unit
        /// <summary>Moves the current drawing position to x, y.</summary>
        /// <param name="x">- the X coordinate to move to</param>
        /// <param name="y">- the Y coordinate to move to</param>
        abstract moveTo: x: float * y: float -> PIXI.Graphics
        /// <summary>Draws a line using the current line style from the current drawing position to (x, y);
        /// The current drawing position is then set to (x, y).</summary>
        /// <param name="x">- the X coordinate to draw to</param>
        /// <param name="y">- the Y coordinate to draw to</param>
        abstract lineTo: x: float * y: float -> PIXI.Graphics
        /// <summary>Initialize the curve</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        abstract _initCurve: ?x: float * ?y: float -> unit
        /// <summary>Calculate the points for a quadratic bezier curve and then draws it.
        /// Based on: https://stackoverflow.com/questions/785097/how-do-i-implement-a-bezier-curve-in-c</summary>
        /// <param name="cpX">- Control point x</param>
        /// <param name="cpY">- Control point y</param>
        /// <param name="toX">- Destination point x</param>
        /// <param name="toY">- Destination point y</param>
        abstract quadraticCurveTo: cpX: float * cpY: float * toX: float * toY: float -> PIXI.Graphics
        /// <summary>Calculate the points for a bezier curve and then draws it.</summary>
        /// <param name="cpX">- Control point x</param>
        /// <param name="cpY">- Control point y</param>
        /// <param name="cpX2">- Second Control point x</param>
        /// <param name="cpY2">- Second Control point y</param>
        /// <param name="toX">- Destination point x</param>
        /// <param name="toY">- Destination point y</param>
        abstract bezierCurveTo: cpX: float * cpY: float * cpX2: float * cpY2: float * toX: float * toY: float -> PIXI.Graphics
        /// <summary>The arcTo() method creates an arc/curve between two tangents on the canvas.
        /// 
        /// "borrowed" from https://code.google.com/p/fxcanvas/ - thanks google!</summary>
        /// <param name="x1">- The x-coordinate of the beginning of the arc</param>
        /// <param name="y1">- The y-coordinate of the beginning of the arc</param>
        /// <param name="x2">- The x-coordinate of the end of the arc</param>
        /// <param name="y2">- The y-coordinate of the end of the arc</param>
        /// <param name="radius">- The radius of the arc</param>
        abstract arcTo: x1: float * y1: float * x2: float * y2: float * radius: float -> PIXI.Graphics
        /// <summary>The arc method creates an arc/curve (used to create circles, or parts of circles).</summary>
        /// <param name="cx">- The x-coordinate of the center of the circle</param>
        /// <param name="cy">- The y-coordinate of the center of the circle</param>
        /// <param name="radius">- The radius of the circle</param>
        /// <param name="startAngle">- The starting angle, in radians (0 is at the 3 o'clock position
        /// of the arc's circle)</param>
        /// <param name="endAngle">- The ending angle, in radians</param>
        /// <param name="anticlockwise">- Specifies whether the drawing should be
        /// counter-clockwise or clockwise. False is default, and indicates clockwise, while true
        /// indicates counter-clockwise.</param>
        abstract arc: cx: float * cy: float * radius: float * startAngle: float * endAngle: float * ?anticlockwise: bool -> PIXI.Graphics
        /// <summary>Specifies a simple one-color fill that subsequent calls to other Graphics methods
        /// (such as lineTo() or drawCircle()) use when drawing.</summary>
        /// <param name="color">- the color of the fill</param>
        /// <param name="alpha">- the alpha of the fill</param>
        abstract beginFill: ?color: float * ?alpha: float -> PIXI.Graphics
        /// <summary>Begin the texture fill</summary>
        /// <param name="texture">- Texture to fill</param>
        /// <param name="color">- Background to fill behind texture</param>
        /// <param name="alpha">- Alpha of fill</param>
        /// <param name="matrix">- Transform matrix</param>
        abstract beginTextureFill: ?texture: PIXI.Texture * ?color: float * ?alpha: float * ?matrix: PIXI.Matrix -> PIXI.Graphics
        /// Applies a fill to the lines and shapes that were added since the last call to the beginFill() method.
        abstract endFill: unit -> PIXI.Graphics
        /// <summary>Draws a rectangle shape.</summary>
        /// <param name="x">- The X coord of the top-left of the rectangle</param>
        /// <param name="y">- The Y coord of the top-left of the rectangle</param>
        /// <param name="width">- The width of the rectangle</param>
        /// <param name="height">- The height of the rectangle</param>
        abstract drawRect: x: float * y: float * width: float * height: float -> PIXI.Graphics
        /// <summary>Draw a rectangle shape with rounded/beveled corners.</summary>
        /// <param name="x">- The X coord of the top-left of the rectangle</param>
        /// <param name="y">- The Y coord of the top-left of the rectangle</param>
        /// <param name="width">- The width of the rectangle</param>
        /// <param name="height">- The height of the rectangle</param>
        /// <param name="radius">- Radius of the rectangle corners</param>
        abstract drawRoundedRect: x: float * y: float * width: float * height: float * radius: float -> PIXI.Graphics
        /// <summary>Draws a circle.</summary>
        /// <param name="x">- The X coordinate of the center of the circle</param>
        /// <param name="y">- The Y coordinate of the center of the circle</param>
        /// <param name="radius">- The radius of the circle</param>
        abstract drawCircle: x: float * y: float * radius: float -> PIXI.Graphics
        /// <summary>Draws an ellipse.</summary>
        /// <param name="x">- The X coordinate of the center of the ellipse</param>
        /// <param name="y">- The Y coordinate of the center of the ellipse</param>
        /// <param name="width">- The half width of the ellipse</param>
        /// <param name="height">- The half height of the ellipse</param>
        abstract drawEllipse: x: float * y: float * width: float * height: float -> PIXI.Graphics
        /// <summary>Draws a polygon using the given path.</summary>
        /// <param name="path">- The path data used to construct the polygon.</param>
        abstract drawPolygon: path: U3<ResizeArray<float>, ResizeArray<PIXI.Point>, PIXI.Polygon> -> PIXI.Graphics
        /// <summary>Draw any shape.</summary>
        /// <param name="shape">- Shape to draw</param>
        abstract drawShape: shape: U5<PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.Rectangle, PIXI.RoundedRectangle> -> PIXI.Graphics
        /// <summary>Draw a star shape with an arbitrary number of points.</summary>
        /// <param name="x">- Center X position of the star</param>
        /// <param name="y">- Center Y position of the star</param>
        /// <param name="points">- The number of points of the star, must be > 1</param>
        /// <param name="radius">- The outer radius of the star</param>
        /// <param name="innerRadius">- The inner radius between points, default half `radius`</param>
        /// <param name="rotation">- The rotation of the star in radians, where 0 is vertical</param>
        abstract drawStar: x: float * y: float * points: float * radius: float * ?innerRadius: float * ?rotation: float -> PIXI.Graphics
        /// Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
        abstract clear: unit -> PIXI.Graphics
        /// True if graphics consists of one rectangle, and thus, can be drawn like a Sprite and
        /// masked with gl.scissor.
        abstract isFastRect: unit -> bool
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// Retrieves the bounds of the graphic shape as a rectangle object
        abstract _calculateBounds: unit -> unit
        /// <summary>Tests if a point is inside this graphics object</summary>
        /// <param name="point">- the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// Recalcuate the tint by applying tin to batches using Graphics tint.
        abstract calculateTints: unit -> unit
        /// If there's a transform update or a change to the shape of the
        /// geometry, recaculate the vertices.
        abstract calculateVertices: unit -> unit
        /// Closes the current path.
        abstract closePath: unit -> PIXI.Graphics
        /// <summary>Apply a matrix to the positional data.</summary>
        /// <param name="matrix">- Matrix to use for transform current shape.</param>
        abstract setMatrix: matrix: PIXI.Matrix -> PIXI.Graphics
        /// Begin adding holes to the last draw shape
        /// IMPORTANT: holes must be fully inside a shape to work
        /// Also weirdness ensues if holes overlap!
        /// Ellipses, Circles, Rectangles and Rounded Rectangles cannot be holes or host for holes in CanvasRenderer,
        /// please use `moveTo` `lineTo`, `quadraticCurveTo` if you rely on pixi-legacy bundle.
        abstract beginHole: unit -> PIXI.Graphics
        /// End adding holes to the last draw shape
        abstract endHole: unit -> PIXI.Graphics
        /// <summary>Destroys the Graphics object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: GraphicsDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] GraphicsDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// The Graphics class contains methods used to draw primitive shapes such as lines, circles and
    /// rectangles to the display, and to color and fill them.
    /// 
    /// Note that because Graphics can share a GraphicsGeometry with other instances,
    /// it is necessary to call `destroy()` to properly dereference the underlying
    /// GraphicsGeometry and avoid a memory leak. Alternatively, keep using the same
    /// Graphics instance and call `clear()` between redraws.
    type [<AllowNullLiteral>] GraphicsStatic =
        [<Emit "new $0($1...)">] abstract Create: ?geometry: PIXI.GraphicsGeometry -> Graphics

    /// A class to contain data useful for Graphics objects
    type [<AllowNullLiteral>] GraphicsData =
        /// The shape object to draw.
        abstract shape: U5<PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.Rectangle, PIXI.RoundedRectangle> with get, set
        /// The style of the line.
        abstract lineStyle: PIXI.LineStyle with get, set
        /// The style of the fill.
        abstract fillStyle: PIXI.FillStyle with get, set
        /// The transform matrix.
        abstract matrix: PIXI.Matrix with get, set
        /// The type of the shape, see the Const.Shapes file for all the existing types,
        abstract ``type``: float with get, set
        /// The collection of points.
        abstract points: ResizeArray<float> with get, set
        /// The collection of holes.
        abstract holes: ResizeArray<PIXI.GraphicsData> with get, set
        /// Creates a new GraphicsData object with the same values as this one.
        abstract clone: unit -> PIXI.GraphicsData
        /// Destroys the Graphics data.
        abstract destroy: unit -> unit

    /// A class to contain data useful for Graphics objects
    type [<AllowNullLiteral>] GraphicsDataStatic =
        [<Emit "new $0($1...)">] abstract Create: shape: U4<PIXI.Circle, PIXI.Rectangle, PIXI.Ellipse, PIXI.Polygon> * ?fillStyle: PIXI.FillStyle * ?lineStyle: PIXI.LineStyle * ?matrix: PIXI.Matrix -> GraphicsData

    /// The Graphics class contains methods used to draw primitive shapes such as lines, circles and
    /// rectangles to the display, and to color and fill them.
    /// 
    /// GraphicsGeometry is designed to not be continually updating the geometry since it's expensive
    /// to re-tesselate using **earcut**. Consider using {@link PIXI.Mesh} for this use-case, it's much faster.
    type [<AllowNullLiteral>] GraphicsGeometry =
        inherit PIXI.BatchGeometry
        /// An array of points to draw
        abstract points: ResizeArray<PIXI.Point> with get, set
        /// The collection of colors
        abstract colors: ResizeArray<float> with get, set
        /// The UVs collection
        abstract uvs: ResizeArray<float> with get, set
        /// The indices of the vertices
        abstract indices: ResizeArray<float> with get, set
        /// Reference to the texture IDs.
        abstract textureIds: ResizeArray<float> with get, set
        /// The collection of drawn shapes.
        abstract graphicsData: ResizeArray<PIXI.GraphicsData> with get, set
        /// Used to detect if the graphics object has changed. If this is set to true then the graphics
        /// object will be recalculated.
        abstract dirty: float with get, set
        /// Batches need to regenerated if the geometry is updated.
        abstract batchDirty: float with get, set
        /// Used to check if the cache is dirty.
        abstract cacheDirty: float with get, set
        /// Used to detect if we clear the graphics WebGL data.
        abstract clearDirty: float with get, set
        /// List of current draw calls drived from the batches.
        abstract drawCalls: ResizeArray<obj option> with get, set
        /// Intermediate abstract format sent to batch system.
        /// Can be converted to drawCalls or to batchable objects.
        abstract batches: ResizeArray<obj option> with get, set
        /// Index of the current last shape in the stack of calls.
        abstract shapeIndex: float with get, set
        /// Cached bounds.
        abstract _bounds: PIXI.Bounds with get, set
        /// The bounds dirty flag.
        abstract boundsDirty: float with get, set
        /// Padding to add to the bounds.
        abstract boundsPadding: float with get, set
        /// Get the current bounds of the graphic geometry.
        abstract bounds: PIXI.Bounds
        /// Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
        abstract clear: unit -> PIXI.GraphicsGeometry
        /// <summary>Draws the given shape to this Graphics object. Can be any of Circle, Rectangle, Ellipse, Line or Polygon.</summary>
        /// <param name="shape">- The shape object to draw.</param>
        /// <param name="fillStyle">- Defines style of the fill.</param>
        /// <param name="lineStyle">- Defines style of the lines.</param>
        /// <param name="matrix">- Transform applied to the points of the shape.</param>
        abstract drawShape: shape: U5<PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.Rectangle, PIXI.RoundedRectangle> * fillStyle: PIXI.FillStyle * lineStyle: PIXI.LineStyle * matrix: PIXI.Matrix -> PIXI.GraphicsGeometry
        /// <summary>Draws the given shape to this Graphics object. Can be any of Circle, Rectangle, Ellipse, Line or Polygon.</summary>
        /// <param name="shape">- The shape object to draw.</param>
        /// <param name="matrix">- Transform applied to the points of the shape.</param>
        abstract drawHole: shape: U5<PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.Rectangle, PIXI.RoundedRectangle> * matrix: PIXI.Matrix -> PIXI.GraphicsGeometry
        /// <summary>Destroys the Graphics object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: GraphicsGeometryDestroyOptions -> unit
        /// <summary>Check to see if a point is contained within this geometry.</summary>
        /// <param name="point">- Point to check if it's contained.</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// Generates intermediate batch data. Either gets converted to drawCalls
        /// or used to convert to batch objects directly by the Graphics object.
        abstract updateBatches: unit -> unit
        /// Checks to see if this graphics geometry can be batched.
        /// Currently it needs to be small enough and not contain any native lines.
        abstract isBatchable: unit -> unit
        /// Converts intermediate batches data to drawCalls.
        abstract buildDrawCalls: unit -> unit
        /// <summary>Process the holes data.</summary>
        /// <param name="holes">- Holes to render</param>
        abstract processHoles: holes: ResizeArray<PIXI.GraphicsData> -> unit
        /// Update the local bounds of the object. Expensive to use performance-wise.
        abstract calculateBounds: unit -> unit
        /// <summary>Transform points using matrix.</summary>
        /// <param name="points">- Points to transform</param>
        /// <param name="matrix">- Transform matrix</param>
        abstract transformPoints: points: ResizeArray<float> * matrix: PIXI.Matrix -> unit
        /// <summary>Add colors.</summary>
        /// <param name="colors">- List of colors to add to</param>
        /// <param name="color">- Color to add</param>
        /// <param name="alpha">- Alpha to use</param>
        /// <param name="size">- Number of colors to add</param>
        abstract addColors: colors: ResizeArray<float> * color: float * alpha: float * size: float -> unit
        /// <summary>Add texture id that the shader/fragment wants to use.</summary>
        /// <param name="textureIds"></param>
        /// <param name="id"></param>
        /// <param name="size"></param>
        abstract addTextureIds: textureIds: ResizeArray<float> * id: float * size: float -> unit
        /// <summary>Generates the UVs for a shape.</summary>
        /// <param name="verts">- Vertices</param>
        /// <param name="uvs">- UVs</param>
        /// <param name="texture">- Reference to Texture</param>
        /// <param name="start">- Index buffer start index.</param>
        /// <param name="size">- The size/length for index buffer.</param>
        /// <param name="matrix">- Optional transform for all points.</param>
        abstract addUvs: verts: ResizeArray<float> * uvs: ResizeArray<float> * texture: PIXI.Texture * start: float * size: float * ?matrix: PIXI.Matrix -> unit
        /// <summary>Modify uvs array according to position of texture region
        /// Does not work with rotated or trimmed textures</summary>
        /// <param name="uvs">array</param>
        /// <param name="texture">region</param>
        /// <param name="start">starting index for uvs</param>
        /// <param name="size">how many points to adjust</param>
        abstract adjustUvs: uvs: float * texture: PIXI.Texture * start: float * size: float -> unit
        /// Buffer used for position, color, texture IDs
        abstract _buffer: PIXI.Buffer with get, set
        /// Index buffer data
        abstract _indexBuffer: PIXI.Buffer with get, set

    type [<AllowNullLiteral>] GraphicsGeometryDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// The Graphics class contains methods used to draw primitive shapes such as lines, circles and
    /// rectangles to the display, and to color and fill them.
    /// 
    /// GraphicsGeometry is designed to not be continually updating the geometry since it's expensive
    /// to re-tesselate using **earcut**. Consider using {@link PIXI.Mesh} for this use-case, it's much faster.
    type [<AllowNullLiteral>] GraphicsGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GraphicsGeometry
        /// The maximum number of points to consider an object "batchable",
        /// able to be batched by the renderer's batch system.
        abstract BATCHABLE_SIZE: float with get, set

    /// Fill style object for Graphics.
    type [<AllowNullLiteral>] FillStyle =
        /// Clones the object
        abstract clone: unit -> PIXI.FillStyle
        /// Reset
        abstract reset: unit -> unit
        /// The hex color value used when coloring the Graphics object.
        abstract color: float with get, set
        /// The alpha value used when filling the Graphics object.
        abstract alpha: float with get, set
        /// The texture to be used for the fill.
        abstract texture: string with get, set
        /// The transform aplpied to the texture.
        abstract matrix: string with get, set
        /// If the current fill is visible.
        abstract visible: bool with get, set
        /// Destroy and don't use after this
        abstract destroy: unit -> unit

    /// Fill style object for Graphics.
    type [<AllowNullLiteral>] FillStyleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FillStyle

    /// Represents the line style for Graphics.
    type [<AllowNullLiteral>] LineStyle =
        inherit PIXI.FillStyle
        /// Clones the object
        abstract clone: unit -> PIXI.LineStyle
        /// Reset the line style to default.
        abstract reset: unit -> unit
        /// The width (thickness) of any lines drawn.
        abstract width: float with get, set
        /// The alignment of any lines drawn (0.5 = middle, 1 = outter, 0 = inner).
        abstract alignment: float with get, set
        /// If true the lines will be draw using LINES instead of TRIANGLE_STRIP
        abstract native: bool with get, set
        /// The hex color value used when coloring the Graphics object.
        abstract color: float with get, set
        /// The alpha value used when filling the Graphics object.
        abstract alpha: float with get, set
        /// The texture to be used for the fill.
        abstract texture: string with get, set
        /// The transform aplpied to the texture.
        abstract matrix: string with get, set
        /// If the current fill is visible.
        abstract visible: bool with get, set
        /// Destroy and don't use after this
        abstract destroy: unit -> unit

    /// Represents the line style for Graphics.
    type [<AllowNullLiteral>] LineStyleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LineStyle

    /// Draw a star shape with an arbitrary number of points.
    type [<AllowNullLiteral>] Star =
        inherit PIXI.Polygon
        /// An array of the points of this polygon
        abstract points: ResizeArray<float> with get, set
        /// The type of the object, mainly used to avoid `instanceof` checks
        abstract ``type``: float
        /// `false` after moveTo, `true` after `closePath`. In all other cases it is `true`.
        abstract closeStroke: bool with get, set
        /// Creates a clone of this polygon
        abstract clone: unit -> PIXI.Polygon
        /// <summary>Checks whether the x and y coordinates passed to this function are contained within this polygon</summary>
        /// <param name="x">- The X coordinate of the point to test</param>
        /// <param name="y">- The Y coordinate of the point to test</param>
        abstract contains: x: float * y: float -> bool

    /// Draw a star shape with an arbitrary number of points.
    type [<AllowNullLiteral>] StarStatic =
        [<Emit "new $0($1...)">] abstract Create: x: float * y: float * points: float * radius: float * ?innerRadius: float * ?rotation: float -> Star

    module Interaction =

        type [<AllowNullLiteral>] IExports =
            abstract InteractionData: InteractionDataStatic
            abstract InteractionEvent: InteractionEventStatic
            abstract InteractionManager: InteractionManagerStatic

        /// Holds all information related to an Interaction event
        type [<AllowNullLiteral>] InteractionData =
            /// This point stores the global coords of where the touch/mouse event happened
            abstract ``global``: PIXI.Point with get, set
            /// The target Sprite that was interacted with
            abstract target: PIXI.Sprite with get, set
            /// When passed to an event handler, this will be the original DOM Event that was captured
            abstract originalEvent: U3<MouseEvent, TouchEvent, PointerEvent> with get, set
            /// Unique identifier for this interaction
            abstract identifier: float with get, set
            /// Indicates whether or not the pointer device that created the event is the primary pointer.
            abstract isPrimary: bool with get, set
            /// Indicates which button was pressed on the mouse or pointer device to trigger the event.
            abstract button: float with get, set
            /// Indicates which buttons are pressed on the mouse or pointer device when the event is triggered.
            abstract buttons: float with get, set
            /// The width of the pointer's contact along the x-axis, measured in CSS pixels.
            /// radiusX of TouchEvents will be represented by this value.
            abstract width: float with get, set
            /// The height of the pointer's contact along the y-axis, measured in CSS pixels.
            /// radiusY of TouchEvents will be represented by this value.
            abstract height: float with get, set
            /// The angle, in degrees, between the pointer device and the screen.
            abstract tiltX: float with get, set
            /// The angle, in degrees, between the pointer device and the screen.
            abstract tiltY: float with get, set
            /// The type of pointer that triggered the event.
            abstract pointerType: string with get, set
            /// Pressure applied by the pointing device during the event. A Touch's force property
            /// will be represented by this value.
            abstract pressure: float with get, set
            /// From TouchEvents (not PointerEvents triggered by touches), the rotationAngle of the Touch.
            abstract rotationAngle: float with get, set
            /// Twist of a stylus pointer.
            abstract twist: float with get, set
            /// Barrel pressure on a stylus pointer.
            abstract tangentialPressure: float with get, set
            /// The unique identifier of the pointer. It will be the same as `identifier`.
            abstract pointerId: float
            /// <summary>This will return the local coordinates of the specified displayObject for this InteractionData</summary>
            /// <param name="displayObject">- The DisplayObject that you would like the local
            /// coords off</param>
            /// <param name="point">- A Point object in which to store the value, optional (otherwise
            /// will create a new point)</param>
            /// <param name="globalPos">- A Point object containing your custom global coords, optional
            /// (otherwise will use the current global coords)</param>
            abstract getLocalPosition: displayObject: PIXI.DisplayObject * ?point: PIXI.Point * ?globalPos: PIXI.Point -> PIXI.Point
            /// <summary>Copies properties from normalized event data.</summary>
            /// <param name="event">The normalized event data</param>
            abstract copyEvent: ``event``: U3<Touch, MouseEvent, PointerEvent> -> unit
            /// Resets the data for pooling.
            abstract reset: unit -> unit

        /// Holds all information related to an Interaction event
        type [<AllowNullLiteral>] InteractionDataStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> InteractionData

        /// Event class that mimics native DOM events.
        type [<AllowNullLiteral>] InteractionEvent =
            /// Whether this event will continue propagating in the tree
            abstract stopped: bool with get, set
            /// The object which caused this event to be dispatched.
            /// For listener callback see {@link PIXI.interaction.InteractionEvent.currentTarget}.
            abstract target: PIXI.DisplayObject with get, set
            /// The object whose event listener’s callback is currently being invoked.
            abstract currentTarget: PIXI.DisplayObject with get, set
            /// Type of the event
            abstract ``type``: string with get, set
            /// InteractionData related to this event
            abstract data: PIXI.Interaction.InteractionData with get, set
            /// Prevents event from reaching any objects other than the current object.
            abstract stopPropagation: unit -> unit
            /// Resets the event.
            abstract reset: unit -> unit

        /// Event class that mimics native DOM events.
        type [<AllowNullLiteral>] InteractionEventStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> InteractionEvent

        /// The interaction manager deals with mouse, touch and pointer events.
        /// 
        /// Any DisplayObject can be interactive if its `interactive` property is set to true.
        /// 
        /// This manager also supports multitouch.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.interaction`
        type [<AllowNullLiteral>] InteractionManager =
            inherit PIXI.Utils.EventEmitter
            /// The renderer this interaction manager works for.
            abstract renderer: PIXI.AbstractRenderer with get, set
            /// Should default browser actions automatically be prevented.
            /// Does not apply to pointer events for backwards compatibility
            /// preventDefault on pointer events stops mouse events from firing
            /// Thus, for every pointer event, there will always be either a mouse of touch event alongside it.
            abstract autoPreventDefault: bool with get, set
            /// Frequency in milliseconds that the mousemove, mouseover & mouseout interaction events will be checked.
            abstract interactionFrequency: float with get, set
            /// The mouse data
            abstract mouse: PIXI.Interaction.InteractionData with get, set
            /// An event data object to handle all the event tracking/dispatching
            abstract eventData: obj option with get, set
            /// The DOM element to bind to.
            abstract interactionDOMElement: Browser.Types.HTMLElement with get, set
            /// This property determines if mousemove and touchmove events are fired only when the cursor
            /// is over the object.
            /// Setting to true will make things work more in line with how the DOM version works.
            /// Setting to false can make things easier for things like dragging
            /// It is currently set to false as this is how PixiJS used to work. This will be set to true in
            /// future versions of pixi.
            abstract moveWhenInside: bool with get, set
            /// Have events been attached to the dom element?
            abstract eventsAdded: bool with get, set
            /// Is the mouse hovering over the renderer?
            abstract mouseOverRenderer: bool with get, set
            /// Does the device support touch events
            /// https://www.w3.org/TR/touch-events/
            abstract supportsTouchEvents: bool
            /// Does the device support pointer events
            /// https://www.w3.org/Submission/pointer-events/
            abstract supportsPointerEvents: bool
            /// Dictionary of how different cursor modes are handled. Strings are handled as CSS cursor
            /// values, objects are handled as dictionaries of CSS values for interactionDOMElement,
            /// and functions are called instead of changing the CSS.
            /// Default CSS cursor values are provided for 'default' and 'pointer' modes.
            abstract cursorStyles: TypeLiteral_03 with get, set
            /// The mode of the cursor that is being used.
            /// The value of this is a key from the cursorStyles dictionary.
            abstract currentCursorMode: string with get, set
            /// The current resolution / device pixel ratio.
            abstract resolution: float with get, set
            /// <summary>Hit tests a point against the display tree, returning the first interactive object that is hit.</summary>
            /// <param name="globalPoint">- A point to hit test with, in global space.</param>
            /// <param name="root">- The root display object to start from. If omitted, defaults
            /// to the last rendered root of the associated renderer.</param>
            abstract hitTest: globalPoint: PIXI.Point * ?root: PIXI.Container -> PIXI.DisplayObject
            /// <summary>Sets the DOM element which will receive mouse/touch events. This is useful for when you have
            /// other DOM elements on top of the renderers Canvas element. With this you'll be bale to delegate
            /// another DOM element to receive those events.</summary>
            /// <param name="element">- the DOM element which will receive mouse and touch events.</param>
            /// <param name="resolution">- The resolution / device pixel ratio of the new element (relative to the canvas).</param>
            abstract setTargetElement: element: Browser.Types.HTMLCanvasElement * ?resolution: float -> unit
            /// <summary>Updates the state of interactive objects.
            /// Invoked by a throttled ticker update from {@link PIXI.Ticker.system}.</summary>
            /// <param name="deltaTime">- time delta since last tick</param>
            abstract update: deltaTime: float -> unit
            /// <summary>Sets the current cursor mode, handling any callbacks or CSS style changes.</summary>
            /// <param name="mode">- cursor mode, a key from the cursorStyles dictionary</param>
            abstract setCursorMode: mode: string -> unit
            /// <summary>Maps x and y coords from a DOM object and maps them correctly to the PixiJS view. The
            /// resulting value is stored in the point. This takes into account the fact that the DOM
            /// element could be scaled and positioned anywhere on the screen.</summary>
            /// <param name="point">- the point that the result will be stored in</param>
            /// <param name="x">- the x coord of the position to map</param>
            /// <param name="y">- the y coord of the position to map</param>
            abstract mapPositionToPoint: point: PIXI.Point * x: float * y: float -> unit
            /// <summary>This function is provides a neat way of crawling through the scene graph and running a
            /// specified function on all interactive objects it finds. It will also take care of hit
            /// testing the interactive objects and passes the hit across in the function.</summary>
            /// <param name="interactionEvent">- event containing the point that
            /// is tested for collision</param>
            /// <param name="displayObject">- the displayObject
            /// that will be hit test (recursively crawls its children)</param>
            /// <param name="func">- the function that will be called on each interactive object. The
            /// interactionEvent, displayObject and hit will be passed to the function</param>
            /// <param name="hitTest">- this indicates if the objects inside should be hit test against the point</param>
            /// <param name="interactive">- Whether the displayObject is interactive</param>
            abstract processInteractive: interactionEvent: PIXI.Interaction.InteractionEvent * displayObject: U3<PIXI.Container, PIXI.Sprite, PIXI.TilingSprite> * ?func: (ResizeArray<obj option> -> obj option) * ?hitTest: bool * ?interactive: bool -> bool
            /// Destroys the interaction manager
            abstract destroy: unit -> unit

        /// The interaction manager deals with mouse, touch and pointer events.
        /// 
        /// Any DisplayObject can be interactive if its `interactive` property is set to true.
        /// 
        /// This manager also supports multitouch.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.interaction`
        type [<AllowNullLiteral>] InteractionManagerStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer * ?options: InteractionManagerStaticOptions -> InteractionManager

        type [<AllowNullLiteral>] InteractionManagerStaticOptions =
            abstract autoPreventDefault: bool option with get, set
            abstract interactionFrequency: float option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] InteractionPointerEvents =
            | Pointerdown
            | Pointercancel
            | Pointerup
            | Pointertap
            | Pointerupoutside
            | Pointermove
            | Pointerover
            | Pointerout

        type [<StringEnum>] [<RequireQualifiedAccess>] InteractionTouchEvents =
            | Touchstart
            | Touchcancel
            | Touchend
            | Touchendoutside
            | Touchmove
            | Tap

        type [<StringEnum>] [<RequireQualifiedAccess>] InteractionMouseEvents =
            | Rightdown
            | Mousedown
            | Rightup
            | Mouseup
            | Rightclick
            | Click
            | Rightupoutside
            | Mouseupoutside
            | Mousemove
            | Mouseout
            | Mouseover

        type [<StringEnum>] [<RequireQualifiedAccess>] InteractionPixiEvents =
            | Added
            | Removed

        type InteractionEventTypes =
            U4<InteractionPointerEvents, InteractionTouchEvents, InteractionMouseEvents, InteractionPixiEvents>

        [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
        module InteractionEventTypes =
            let ofInteractionPointerEvents v: InteractionEventTypes = v |> U4.Case1
            let isInteractionPointerEvents (v: InteractionEventTypes) = match v with U4.Case1 _ -> true | _ -> false
            let asInteractionPointerEvents (v: InteractionEventTypes) = match v with U4.Case1 o -> Some o | _ -> None
            let ofInteractionTouchEvents v: InteractionEventTypes = v |> U4.Case2
            let isInteractionTouchEvents (v: InteractionEventTypes) = match v with U4.Case2 _ -> true | _ -> false
            let asInteractionTouchEvents (v: InteractionEventTypes) = match v with U4.Case2 o -> Some o | _ -> None
            let ofInteractionMouseEvents v: InteractionEventTypes = v |> U4.Case3
            let isInteractionMouseEvents (v: InteractionEventTypes) = match v with U4.Case3 _ -> true | _ -> false
            let asInteractionMouseEvents (v: InteractionEventTypes) = match v with U4.Case3 o -> Some o | _ -> None
            let ofInteractionPixiEvents v: InteractionEventTypes = v |> U4.Case4
            let isInteractionPixiEvents (v: InteractionEventTypes) = match v with U4.Case4 _ -> true | _ -> false
            let asInteractionPixiEvents (v: InteractionEventTypes) = match v with U4.Case4 o -> Some o | _ -> None

        type [<AllowNullLiteral>] TypeLiteral_03 =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

    /// Application plugin for supporting loader option. Installing the LoaderPlugin
    /// is not necessary if using **pixi.js** or **pixi.js-legacy**.
    type [<AllowNullLiteral>] AppLoaderPlugin =
        interface end

    /// Application plugin for supporting loader option. Installing the LoaderPlugin
    /// is not necessary if using **pixi.js** or **pixi.js-legacy**.
    type [<AllowNullLiteral>] AppLoaderPluginStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> AppLoaderPlugin

    /// Reference to **{@link https://github.com/englercj/resource-loader
    /// resource-loader}**'s Resource class.
    type [<AllowNullLiteral>] LoaderResource =
        abstract name: string with get, set
        abstract url: string with get, set
        abstract extension: string with get, set
        abstract data: obj option with get, set
        abstract crossOrigin: U2<bool, string> with get, set
        abstract loadType: float with get, set
        abstract xhrType: string with get, set
        abstract metadata: obj option with get, set
        abstract error: Error with get, set
        // TODO abstract xhr: XMLHttpRequest option with get, set
        abstract children: ResizeArray<LoaderResource> with get, set
        abstract ``type``: float with get, set
        abstract progressChunk: float with get, set
        abstract isDataUrl: bool with get, set
        abstract isComplete: bool with get, set
        abstract isLoading: bool with get, set
        abstract complete: unit -> unit
        abstract abort: ?message: string -> unit
        abstract load: ?cb: (unit->unit) -> unit
        abstract texture: Texture with get, set
        abstract spineAtlas: obj option with get, set
        abstract spineData: obj option with get, set
        abstract spritesheet: Spritesheet option with get, set
        abstract textures: ITextureDictionary option with get, set

    /// Reference to **{@link https://github.com/englercj/resource-loader
    /// resource-loader}**'s Resource class.
    type [<AllowNullLiteral>] LoaderResourceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LoaderResource

    type [<AllowNullLiteral>] ILoaderPlugin =
        abstract add: (ResizeArray<obj option> -> obj option) option with get, set
        // TODO abstract pre: PIXI.Loader.LoaderMiddleware option with get, set
        // TODO abstract ``use``: PIXI.Loader.LoaderMiddleware option with get, set

    module Loader =

        type [<AllowNullLiteral>] loaderMiddleware =
            [<Emit "$0($1...)">] abstract Invoke: resource: PIXI.LoaderResource * next: (ResizeArray<obj option> -> obj option) -> unit

    /// The new loader, extends Resource Loader by Chad Engler: https://github.com/englercj/resource-loader
    /// 
    /// ```js
    /// const loader = PIXI.Loader.shared; // PixiJS exposes a premade instance for you to use.
    /// //or
    /// const loader = new PIXI.Loader(); // you can also create your own if you want
    /// 
    /// const sprites = {};
    /// 
    /// // Chainable `add` to enqueue a resource
    /// loader.add('bunny', 'data/bunny.png')
    ///        .add('spaceship', 'assets/spritesheet.json');
    /// loader.add('scoreFont', 'assets/score.fnt');
    /// 
    /// // Chainable `pre` to add a middleware that runs for each resource, *before* loading that resource.
    /// // This is useful to implement custom caching modules (using filesystem, indexeddb, memory, etc).
    /// loader.pre(cachingMiddleware);
    /// 
    /// // Chainable `use` to add a middleware that runs for each resource, *after* loading that resource.
    /// // This is useful to implement custom parsing modules (like spritesheet parsers, spine parser, etc).
    /// loader.use(parsingMiddleware);
    /// 
    /// // The `load` method loads the queue of resources, and calls the passed in callback called once all
    /// // resources have loaded.
    /// loader.load((loader, resources) => {
    ///      // resources is an object where the key is the name of the resource loaded and the value is the resource object.
    ///      // They have a couple default properties:
    ///      // - `url`: The URL that the resource was loaded from
    ///      // - `error`: The error that happened when trying to load (if any)
    ///      // - `data`: The raw data that was loaded
    ///      // also may contain other properties based on the middleware that runs.
    ///      sprites.bunny = new PIXI.TilingSprite(resources.bunny.texture);
    ///      sprites.spaceship = new PIXI.TilingSprite(resources.spaceship.texture);
    ///      sprites.scoreFont = new PIXI.TilingSprite(resources.scoreFont.texture);
    /// });
    /// 
    /// // throughout the process multiple signals can be dispatched.
    /// loader.onProgress.add(() => {}); // called once per loaded/errored file
    /// loader.onError.add(() => {}); // called once per errored file
    /// loader.onLoad.add(() => {}); // called once per loaded file
    /// loader.onComplete.add(() => {}); // called once when the queued resources all load.
    /// ```
    type [<AllowNullLiteral>] Loader =
        inherit Utils.EventEmitter
        abstract onStart: obj option with get, set
        abstract onProgress: obj option with get, set
        abstract onError: obj option with get, set
        abstract onLoad: obj option with get, set
        abstract onComplete: obj option with get, set
        abstract baseUrl: string with get, set
        abstract progress: float with get, set
        abstract loading: bool with get, set
        abstract defaultQueryString: string with get, set
        abstract resources: IResourceDictionary with get, set
        abstract concurrency: float with get, set
        abstract add: [<ParamArray>] ``params``: ResizeArray<obj option> -> Loader
        abstract add: name: string * url: string * ?options: ILoaderOptions * ?cb: (unit->unit) -> Loader
        abstract add: obj: U3<string, obj option, ResizeArray<obj option>> * ?options: ILoaderOptions * ?cb: (unit->unit) -> Loader
        abstract pre: fn: (unit->unit) -> Loader
        abstract ``use``: fn: (unit->unit) -> Loader
        abstract reset: unit -> Loader
        abstract load: ?cb: (unit->unit) -> Loader
        abstract destroy: unit -> unit
        [<Emit "$0.on('complete',$1,$2)">] abstract on_complete: fn: (Loader -> obj option -> unit) * ?context: obj -> Loader
        [<Emit "$0.on('error',$1,$2)">] abstract on_error: fn: (Error -> Loader -> LoaderResource -> unit) * ?context: obj -> Loader
        abstract on: ``event``: U2<string, string> * fn: (Loader -> LoaderResource -> unit) * ?context: obj -> Loader
        [<Emit "$0.on('start',$1,$2)">] abstract on_start: fn: (Loader -> unit) * ?context: obj -> Loader
        [<Emit "$0.once('complete',$1,$2)">] abstract once_complete: fn: (Loader -> obj option -> unit) * ?context: obj -> Loader
        [<Emit "$0.once('error',$1,$2)">] abstract once_error: fn: (Error -> Loader -> LoaderResource -> unit) * ?context: obj -> Loader
        abstract once: ``event``: U2<string, string> * fn: (Loader -> LoaderResource -> unit) * ?context: obj -> Loader
        [<Emit "$0.once('start',$1,$2)">] abstract once_start: fn: (Loader -> unit) * ?context: obj -> Loader
        abstract off: ``event``: U6<string, string, string, string, string, string> * ?fn: (unit->unit) * ?context: obj -> Loader

    /// The new loader, extends Resource Loader by Chad Engler: https://github.com/englercj/resource-loader
    /// 
    /// ```js
    /// const loader = PIXI.Loader.shared; // PixiJS exposes a premade instance for you to use.
    /// //or
    /// const loader = new PIXI.Loader(); // you can also create your own if you want
    /// 
    /// const sprites = {};
    /// 
    /// // Chainable `add` to enqueue a resource
    /// loader.add('bunny', 'data/bunny.png')
    ///        .add('spaceship', 'assets/spritesheet.json');
    /// loader.add('scoreFont', 'assets/score.fnt');
    /// 
    /// // Chainable `pre` to add a middleware that runs for each resource, *before* loading that resource.
    /// // This is useful to implement custom caching modules (using filesystem, indexeddb, memory, etc).
    /// loader.pre(cachingMiddleware);
    /// 
    /// // Chainable `use` to add a middleware that runs for each resource, *after* loading that resource.
    /// // This is useful to implement custom parsing modules (like spritesheet parsers, spine parser, etc).
    /// loader.use(parsingMiddleware);
    /// 
    /// // The `load` method loads the queue of resources, and calls the passed in callback called once all
    /// // resources have loaded.
    /// loader.load((loader, resources) => {
    ///      // resources is an object where the key is the name of the resource loaded and the value is the resource object.
    ///      // They have a couple default properties:
    ///      // - `url`: The URL that the resource was loaded from
    ///      // - `error`: The error that happened when trying to load (if any)
    ///      // - `data`: The raw data that was loaded
    ///      // also may contain other properties based on the middleware that runs.
    ///      sprites.bunny = new PIXI.TilingSprite(resources.bunny.texture);
    ///      sprites.spaceship = new PIXI.TilingSprite(resources.spaceship.texture);
    ///      sprites.scoreFont = new PIXI.TilingSprite(resources.scoreFont.texture);
    /// });
    /// 
    /// // throughout the process multiple signals can be dispatched.
    /// loader.onProgress.add(() => {}); // called once per loaded/errored file
    /// loader.onError.add(() => {}); // called once per errored file
    /// loader.onLoad.add(() => {}); // called once per loaded file
    /// loader.onComplete.add(() => {}); // called once when the queued resources all load.
    /// ```
    type [<AllowNullLiteral>] LoaderStatic =
        [<Emit "new $0($1...)">] abstract Create: ?baseUrl: string * ?concurrency: float -> Loader
        /// A premade instance of the loader that can be used to load resources.
        abstract shared: PIXI.Loader with get, set
        /// <summary>Adds a Loader plugin for the global shared loader and all
        /// new Loader instances created.</summary>
        /// <param name="plugin">- The plugin to add</param>
        abstract registerPlugin: plugin: PIXI.ILoaderPlugin -> PIXI.Loader

    /// Loader plugin for handling Texture resources.
    type [<AllowNullLiteral>] TextureLoader =
        inherit PIXI.ILoaderPlugin

    /// Loader plugin for handling Texture resources.
    type [<AllowNullLiteral>] TextureLoaderStatic =
        /// <summary>Called after a resource is loaded.</summary>
        /// <param name="resource"></param>
        /// <param name="next"></param>
        abstract ``use``: resource: PIXI.LoaderResource * next: (ResizeArray<obj option> -> obj option) -> unit

    /// Implements Dihedral Group D_8, see [group D4]{@link http://mathworld.wolfram.com/DihedralGroupD4.html},
    /// D8 is the same but with diagonals. Used for texture rotations.
    /// 
    /// Vector xX(i), xY(i) is U-axis of sprite with rotation i
    /// Vector yY(i), yY(i) is V-axis of sprite with rotation i
    /// Rotations: 0 grad (0), 90 grad (2), 180 grad (4), 270 grad (6)
    /// Mirrors: vertical (8), main diagonal (10), horizontal (12), reverse diagonal (14)
    /// This is the small part of gameofbombs.com portal system. It works.
    type [<AllowNullLiteral>] GroupD8 =
        interface end

    /// Implements Dihedral Group D_8, see [group D4]{@link http://mathworld.wolfram.com/DihedralGroupD4.html},
    /// D8 is the same but with diagonals. Used for texture rotations.
    /// 
    /// Vector xX(i), xY(i) is U-axis of sprite with rotation i
    /// Vector yY(i), yY(i) is V-axis of sprite with rotation i
    /// Rotations: 0 grad (0), 90 grad (2), 180 grad (4), 270 grad (6)
    /// Mirrors: vertical (8), main diagonal (10), horizontal (12), reverse diagonal (14)
    /// This is the small part of gameofbombs.com portal system. It works.
    type [<AllowNullLiteral>] GroupD8Static =
        [<Emit "new $0($1...)">] abstract Create: unit -> GroupD8
        /// <summary>Adds 180 degrees to rotation. Commutative operation.</summary>
        /// <param name="rotation">- The number to rotate.</param>
        abstract rotate180: rotation: float -> float
        /// <summary>Direction of main vector can be horizontal, vertical or diagonal.
        /// Some objects work with vertical directions different.</summary>
        /// <param name="rotation">- The number to check.</param>
        abstract isVertical: rotation: float -> bool
        /// <param name="dx">- TODO</param>
        /// <param name="dy">- TODO</param>
        abstract byDirection: dx: float * dy: float -> float
        /// <summary>Helps sprite to compensate texture packer rotation.</summary>
        /// <param name="matrix">- sprite world matrix</param>
        /// <param name="rotation">- The rotation factor to use.</param>
        /// <param name="tx">- sprite anchoring</param>
        /// <param name="ty">- sprite anchoring</param>
        abstract matrixAppendRotationInv: matrix: PIXI.Matrix * rotation: float * tx: float * ty: float -> unit

    /// The PixiJS Matrix as a class makes it a lot faster.
    /// 
    /// Here is a representation of it:
    /// ```js
    /// | a | c | tx|
    /// | b | d | ty|
    /// | 0 | 0 | 1 |
    /// ```
    type [<AllowNullLiteral>] Matrix =
        abstract copy: unit -> unit
        abstract a: float with get, set
        abstract b: float with get, set
        abstract c: float with get, set
        abstract d: float with get, set
        abstract tx: float with get, set
        abstract ty: float with get, set
        /// <summary>Creates a Matrix object based on the given array. The Element to Matrix mapping order is as follows:
        /// 
        /// a = array[0]
        /// b = array[1]
        /// c = array[3]
        /// d = array[4]
        /// tx = array[2]
        /// ty = array[5]</summary>
        /// <param name="array">- The array that the matrix will be populated from.</param>
        abstract fromArray: array: ResizeArray<float> -> unit
        /// <summary>sets the matrix properties</summary>
        /// <param name="a">- Matrix component</param>
        /// <param name="b">- Matrix component</param>
        /// <param name="c">- Matrix component</param>
        /// <param name="d">- Matrix component</param>
        /// <param name="tx">- Matrix component</param>
        /// <param name="ty">- Matrix component</param>
        abstract set: a: float * b: float * c: float * d: float * tx: float * ty: float -> PIXI.Matrix
        /// <summary>Creates an array from the current Matrix object.</summary>
        /// <param name="transpose">- Whether we need to transpose the matrix or not</param>
        /// <param name="out">- If provided the array will be assigned to out</param>
        abstract toArray: transpose: bool * ?out: float [] -> ResizeArray<float>
        /// <summary>Get a new position with the current transformation applied.
        /// Can be used to go from a child's coordinate space to the world coordinate space. (e.g. rendering)</summary>
        /// <param name="pos">- The origin</param>
        /// <param name="newPos">- The point that the new position is assigned to (allowed to be same as input)</param>
        abstract apply: pos: PIXI.Point * ?newPos: PIXI.Point -> PIXI.Point
        /// <summary>Get a new position with the inverse of the current transformation applied.
        /// Can be used to go from the world coordinate space to a child's coordinate space. (e.g. input)</summary>
        /// <param name="pos">- The origin</param>
        /// <param name="newPos">- The point that the new position is assigned to (allowed to be same as input)</param>
        abstract applyInverse: pos: PIXI.Point * ?newPos: PIXI.Point -> PIXI.Point
        /// <summary>Translates the matrix on the x and y.</summary>
        /// <param name="x">How much to translate x by</param>
        /// <param name="y">How much to translate y by</param>
        abstract translate: x: float * y: float -> PIXI.Matrix
        /// <summary>Applies a scale transformation to the matrix.</summary>
        /// <param name="x">The amount to scale horizontally</param>
        /// <param name="y">The amount to scale vertically</param>
        abstract scale: x: float * y: float -> PIXI.Matrix
        /// <summary>Applies a rotation transformation to the matrix.</summary>
        /// <param name="angle">- The angle in radians.</param>
        abstract rotate: angle: float -> PIXI.Matrix
        /// <summary>Appends the given Matrix to this Matrix.</summary>
        /// <param name="matrix">- The matrix to append.</param>
        abstract append: matrix: PIXI.Matrix -> PIXI.Matrix
        /// <summary>Sets the matrix based on all the available properties</summary>
        /// <param name="x">- Position on the x axis</param>
        /// <param name="y">- Position on the y axis</param>
        /// <param name="pivotX">- Pivot on the x axis</param>
        /// <param name="pivotY">- Pivot on the y axis</param>
        /// <param name="scaleX">- Scale on the x axis</param>
        /// <param name="scaleY">- Scale on the y axis</param>
        /// <param name="rotation">- Rotation in radians</param>
        /// <param name="skewX">- Skew on the x axis</param>
        /// <param name="skewY">- Skew on the y axis</param>
        abstract setTransform: x: float * y: float * pivotX: float * pivotY: float * scaleX: float * scaleY: float * rotation: float * skewX: float * skewY: float -> PIXI.Matrix
        /// <summary>Prepends the given Matrix to this Matrix.</summary>
        /// <param name="matrix">- The matrix to prepend</param>
        abstract prepend: matrix: PIXI.Matrix -> PIXI.Matrix
        /// <summary>Decomposes the matrix (x, y, scaleX, scaleY, and rotation) and sets the properties on to a transform.</summary>
        /// <param name="transform">- The transform to apply the properties to.</param>
        abstract decompose: transform: PIXI.Transform -> PIXI.Transform
        /// Inverts this matrix
        abstract invert: unit -> PIXI.Matrix
        /// Resets this Matrix to an identity (default) matrix.
        abstract identity: unit -> PIXI.Matrix
        /// Creates a new Matrix object with the same values as this one.
        abstract clone: unit -> PIXI.Matrix
        /// <summary>Changes the values of the given matrix to be the same as the ones in this matrix</summary>
        /// <param name="matrix">- The matrix to copy to.</param>
        abstract copyTo: matrix: PIXI.Matrix -> PIXI.Matrix
        /// <summary>Changes the values of the matrix to be the same as the ones in given matrix</summary>
        /// <param name="matrix">- The matrix to copy from.</param>
        abstract copyFrom: matrix: PIXI.Matrix -> PIXI.Matrix

    /// The PixiJS Matrix as a class makes it a lot faster.
    /// 
    /// Here is a representation of it:
    /// ```js
    /// | a | c | tx|
    /// | b | d | ty|
    /// | 0 | 0 | 1 |
    /// ```
    type [<AllowNullLiteral>] MatrixStatic =
        [<Emit "new $0($1...)">] abstract Create: ?a: float * ?b: float * ?c: float * ?d: float * ?tx: float * ?ty: float -> Matrix
        /// A default (identity) matrix
        abstract IDENTITY: PIXI.Matrix with get, set
        /// A temp matrix
        abstract TEMP_MATRIX: PIXI.Matrix with get, set

    type IPoint =
        U2<PIXI.Point, PIXI.ObservablePoint>

    (* TODO 
    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module IPoint =
        let ofPIXI.Point v: IPoint = v |> U2.Case1
        let isPIXI.Point (v: IPoint) = match v with U2.Case1 _ -> true | _ -> false
        let asPIXI.Point (v: IPoint) = match v with U2.Case1 o -> Some o | _ -> None
        let ofPIXI.ObservablePoint v: IPoint = v |> U2.Case2
        let isPIXI.ObservablePoint (v: IPoint) = match v with U2.Case2 _ -> true | _ -> false
        let asPIXI.ObservablePoint (v: IPoint) = match v with U2.Case2 o -> Some o | _ -> None
        *)

    /// The Point object represents a location in a two-dimensional coordinate system, where x represents
    /// the horizontal axis and y represents the vertical axis.
    /// 
    /// An ObservablePoint is a point that triggers a callback when the point's position is changed.
    type [<AllowNullLiteral>] ObservablePoint =
        abstract copy: unit -> unit
        /// <summary>Creates a clone of this point.
        /// The callback and scope params can be overidden otherwise they will default
        /// to the clone object's values.</summary>
        /// <param name="cb">- callback when changed</param>
        /// <param name="scope">- owner of callback</param>
        abstract clone: ?cb: (ResizeArray<obj option> -> obj option) * ?scope: obj -> PIXI.ObservablePoint
        /// <summary>Sets the point to a new x and y position.
        /// If y is omitted, both x and y will be set to x.</summary>
        /// <param name="x">- position of the point on the x axis</param>
        /// <param name="y">- position of the point on the y axis</param>
        abstract set: ?x: float * ?y: float -> unit
        /// <summary>Copies x and y from the given point</summary>
        /// <param name="p">- The point to copy from.</param>
        abstract copyFrom: p: PIXI.IPoint -> PIXI.IPoint
        /// <summary>Copies x and y into the given point</summary>
        /// <param name="p">- The point to copy.</param>
        abstract copyTo: p: PIXI.IPoint -> PIXI.IPoint
        /// <summary>Returns true if the given point is equal to this point</summary>
        /// <param name="p">- The point to check</param>
        abstract equals: p: PIXI.IPoint -> bool
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        abstract x: float with get, set
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        abstract y: float with get, set

    /// The Point object represents a location in a two-dimensional coordinate system, where x represents
    /// the horizontal axis and y represents the vertical axis.
    /// 
    /// An ObservablePoint is a point that triggers a callback when the point's position is changed.
    type [<AllowNullLiteral>] ObservablePointStatic =
        [<Emit "new $0($1...)">] abstract Create: cb: (ResizeArray<obj option> -> obj option) * scope: obj option * ?x: float * ?y: float -> ObservablePoint

    /// The Point object represents a location in a two-dimensional coordinate system, where x represents
    /// the horizontal axis and y represents the vertical axis.
    type [<AllowNullLiteral>] Point =
        abstract copy: unit -> unit
        abstract x: float with get, set
        abstract y: float with get, set
        /// Creates a clone of this point
        abstract clone: unit -> PIXI.Point
        /// <summary>Copies x and y from the given point</summary>
        /// <param name="p">- The point to copy from</param>
        abstract copyFrom: p: PIXI.IPoint -> PIXI.IPoint
        /// <summary>Copies x and y into the given point</summary>
        /// <param name="p">- The point to copy.</param>
        abstract copyTo: p: PIXI.IPoint -> PIXI.IPoint
        /// <summary>Returns true if the given point is equal to this point</summary>
        /// <param name="p">- The point to check</param>
        abstract equals: p: PIXI.IPoint -> bool
        /// <summary>Sets the point to a new x and y position.
        /// If y is omitted, both x and y will be set to x.</summary>
        /// <param name="x">- position of the point on the x axis</param>
        /// <param name="y">- position of the point on the y axis</param>
        abstract set: ?x: float * ?y: float -> unit

    /// The Point object represents a location in a two-dimensional coordinate system, where x represents
    /// the horizontal axis and y represents the vertical axis.
    type [<AllowNullLiteral>] PointStatic =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float -> Point

    /// The Circle object is used to help draw graphics and can also be used to specify a hit area for displayObjects.
    type [<AllowNullLiteral>] Circle =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract radius: float with get, set
        /// The type of the object, mainly used to avoid `instanceof` checks
        abstract ``type``: float
        /// Creates a clone of this Circle instance
        abstract clone: unit -> PIXI.Circle
        /// <summary>Checks whether the x and y coordinates given are contained within this circle</summary>
        /// <param name="x">- The X coordinate of the point to test</param>
        /// <param name="y">- The Y coordinate of the point to test</param>
        abstract contains: x: float * y: float -> bool
        /// Returns the framing rectangle of the circle as a Rectangle object
        abstract getBounds: unit -> PIXI.Rectangle

    /// The Circle object is used to help draw graphics and can also be used to specify a hit area for displayObjects.
    type [<AllowNullLiteral>] CircleStatic =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?radius: float -> Circle

    /// The Ellipse object is used to help draw graphics and can also be used to specify a hit area for displayObjects.
    type [<AllowNullLiteral>] Ellipse =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        /// The type of the object, mainly used to avoid `instanceof` checks
        abstract ``type``: float
        /// Creates a clone of this Ellipse instance
        abstract clone: unit -> PIXI.Ellipse
        /// <summary>Checks whether the x and y coordinates given are contained within this ellipse</summary>
        /// <param name="x">- The X coordinate of the point to test</param>
        /// <param name="y">- The Y coordinate of the point to test</param>
        abstract contains: x: float * y: float -> bool
        /// Returns the framing rectangle of the ellipse as a Rectangle object
        abstract getBounds: unit -> PIXI.Rectangle

    /// The Ellipse object is used to help draw graphics and can also be used to specify a hit area for displayObjects.
    type [<AllowNullLiteral>] EllipseStatic =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?halfWidth: float * ?halfHeight: float -> Ellipse

    /// A class to define a shape via user defined co-orinates.
    type [<AllowNullLiteral>] Polygon =
        /// An array of the points of this polygon
        abstract points: ResizeArray<float> with get, set
        /// The type of the object, mainly used to avoid `instanceof` checks
        abstract ``type``: float
        /// `false` after moveTo, `true` after `closePath`. In all other cases it is `true`.
        abstract closeStroke: bool with get, set
        /// Creates a clone of this polygon
        abstract clone: unit -> PIXI.Polygon
        /// <summary>Checks whether the x and y coordinates passed to this function are contained within this polygon</summary>
        /// <param name="x">- The X coordinate of the point to test</param>
        /// <param name="y">- The Y coordinate of the point to test</param>
        abstract contains: x: float * y: float -> bool

    /// A class to define a shape via user defined co-orinates.
    type [<AllowNullLiteral>] PolygonStatic =
        [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] points: ResizeArray<U2<ResizeArray<PIXI.Point>, ResizeArray<float>>> -> Polygon

    /// Rectangle object is an area defined by its position, as indicated by its top-left corner
    /// point (x, y) and by its width and its height.
    type [<AllowNullLiteral>] Rectangle =
        abstract copy: unit -> unit
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        /// The type of the object, mainly used to avoid `instanceof` checks
        abstract ``type``: float
        /// returns the left edge of the rectangle
        abstract left: float with get, set
        /// returns the right edge of the rectangle
        abstract right: float with get, set
        /// returns the top edge of the rectangle
        abstract top: float with get, set
        /// returns the bottom edge of the rectangle
        abstract bottom: float with get, set
        /// Creates a clone of this Rectangle
        abstract clone: unit -> PIXI.Rectangle
        /// <summary>Copies another rectangle to this one.</summary>
        /// <param name="rectangle">- The rectangle to copy from.</param>
        abstract copyFrom: rectangle: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Copies this rectangle to another one.</summary>
        /// <param name="rectangle">- The rectangle to copy to.</param>
        abstract copyTo: rectangle: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Checks whether the x and y coordinates given are contained within this Rectangle</summary>
        /// <param name="x">- The X coordinate of the point to test</param>
        /// <param name="y">- The Y coordinate of the point to test</param>
        abstract contains: x: float * y: float -> bool
        /// <summary>Pads the rectangle making it grow in all directions.</summary>
        /// <param name="paddingX">- The horizontal padding amount.</param>
        /// <param name="paddingY">- The vertical padding amount.</param>
        abstract pad: paddingX: float * paddingY: float -> unit
        /// <summary>Fits this rectangle around the passed one.</summary>
        /// <param name="rectangle">- The rectangle to fit.</param>
        abstract fit: rectangle: PIXI.Rectangle -> unit
        /// <summary>Enlarges rectangle that way its corners lie on grid</summary>
        /// <param name="resolution">resolution</param>
        /// <param name="eps">precision</param>
        abstract ceil: ?resolution: float * ?eps: float -> unit
        /// <summary>Enlarges this rectangle to include the passed rectangle.</summary>
        /// <param name="rectangle">- The rectangle to include.</param>
        abstract enlarge: rectangle: PIXI.Rectangle -> unit

    /// Rectangle object is an area defined by its position, as indicated by its top-left corner
    /// point (x, y) and by its width and its height.
    type [<AllowNullLiteral>] RectangleStatic =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?width: float * ?height: float -> Rectangle
        /// A constant empty rectangle.
        abstract EMPTY: PIXI.Rectangle with get, set

    /// The Rounded Rectangle object is an area that has nice rounded corners, as indicated by its
    /// top-left corner point (x, y) and by its width and its height and its radius.
    type [<AllowNullLiteral>] RoundedRectangle =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract radius: float with get, set
        /// The type of the object, mainly used to avoid `instanceof` checks
        abstract ``type``: float
        /// Creates a clone of this Rounded Rectangle
        abstract clone: unit -> PIXI.RoundedRectangle
        /// <summary>Checks whether the x and y coordinates given are contained within this Rounded Rectangle</summary>
        /// <param name="x">- The X coordinate of the point to test</param>
        /// <param name="y">- The Y coordinate of the point to test</param>
        abstract contains: x: float * y: float -> bool

    /// The Rounded Rectangle object is an area that has nice rounded corners, as indicated by its
    /// top-left corner point (x, y) and by its width and its height and its radius.
    type [<AllowNullLiteral>] RoundedRectangleStatic =
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float * ?width: float * ?height: float * ?radius: float -> RoundedRectangle

    /// Transform that takes care about its versions
    type [<AllowNullLiteral>] Transform =
        /// The global matrix transform. It can be swapped temporarily by some functions like getLocalBounds()
        abstract worldTransform: PIXI.Matrix with get, set
        /// The local matrix transform
        abstract localTransform: PIXI.Matrix with get, set
        /// The coordinate of the object relative to the local coordinates of the parent.
        abstract position: PIXI.ObservablePoint with get, set
        /// The scale factor of the object.
        abstract scale: PIXI.ObservablePoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        abstract pivot: PIXI.ObservablePoint with get, set
        /// The skew amount, on the x and y axis.
        abstract skew: PIXI.ObservablePoint with get, set
        /// Updates only local matrix
        abstract updateLocalTransform: unit -> unit
        /// <summary>Updates the values of the object and applies the parent's transform.</summary>
        /// <param name="parentTransform">- The transform of the parent of this object</param>
        abstract updateTransform: parentTransform: PIXI.Transform -> unit
        /// <summary>Decomposes a matrix and sets the transforms properties based on it.</summary>
        /// <param name="matrix">- The matrix to decompose</param>
        abstract setFromMatrix: matrix: PIXI.Matrix -> unit
        /// The rotation of the object in radians.
        abstract rotation: float with get, set

    /// Transform that takes care about its versions
    (*
    type [<AllowNullLiteral>] TransformStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Transform
*)
    /// Base mesh class.
    /// 
    /// This class empowers you to have maximum flexibility to render any kind of WebGL visuals you can think of.
    /// This class assumes a certain level of WebGL knowledge.
    /// If you know a bit this should abstract enough away to make you life easier!
    /// 
    /// Pretty much ALL WebGL can be broken down into the following:
    /// - Geometry - The structure and data for the mesh. This can include anything from positions, uvs, normals, colors etc..
    /// - Shader - This is the shader that PixiJS will render the geometry with (attributes in the shader must match the geometry)
    /// - State - This is the state of WebGL required to render the mesh.
    /// 
    /// Through a combination of the above elements you can render anything you want, 2D or 3D!
    type [<AllowNullLiteral>] Mesh =
        inherit PIXI.Container
        /// Includes vertex positions, face indices, normals, colors, UVs, and
        /// custom attributes within buffers, reducing the cost of passing all
        /// this data to the GPU. Can be shared between multiple Mesh objects.
        abstract geometry: PIXI.Geometry
        /// Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
        /// Can be shared between multiple Mesh objects.
        abstract shader: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// Represents the WebGL state the Mesh required to render, excludes shader and geometry. E.g.,
        /// blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
        abstract state: PIXI.State with get, set
        /// The way the Mesh should be drawn, can be any of the {@link PIXI.DRAW_MODES} constants.
        abstract drawMode: float with get, set
        /// Typically the index of the IndexBuffer where to start drawing.
        abstract start: float with get, set
        /// How much of the geometry to draw, by default `0` renders everything.
        abstract size: float with get, set
        /// To change mesh uv's, change its uvBuffer data and increment its _updateID.
        abstract uvBuffer: PIXI.Buffer
        /// To change mesh vertices, change its uvBuffer data and increment its _updateID.
        /// Incrementing _updateID is optional because most of Mesh objects do it anyway.
        abstract verticesBuffer: PIXI.Buffer
        /// Alias for {@link PIXI.Mesh#shader}.
        abstract material: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// The blend mode to be applied to the Mesh. Apply a value of
        /// `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The multiply tint applied to the Mesh. This is a hex value. A value of
        /// `0xFFFFFF` will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the Mesh uses.
        abstract texture: PIXI.Texture with get, set
        /// Standard renderer draw.
        abstract _render: unit -> unit
        /// <summary>Standard non-batching way of rendering.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderDefault: renderer: PIXI.Renderer -> unit
        /// <summary>Rendering by using the Batch system.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderToBatch: renderer: PIXI.Renderer -> unit
        /// Updates vertexData field based on transform and vertices
        abstract calculateVertices: unit -> unit
        /// Updates uv field based on from geometry uv's or batchUvs
        abstract calculateUvs: unit -> unit
        /// Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
        /// there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
        abstract _calculateBounds: unit -> unit
        /// <summary>Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.</summary>
        /// <param name="point">the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys the Mesh object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: MeshDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] MeshDestroyOptions =
        abstract children: bool option with get, set

    /// Base mesh class.
    /// 
    /// This class empowers you to have maximum flexibility to render any kind of WebGL visuals you can think of.
    /// This class assumes a certain level of WebGL knowledge.
    /// If you know a bit this should abstract enough away to make you life easier!
    /// 
    /// Pretty much ALL WebGL can be broken down into the following:
    /// - Geometry - The structure and data for the mesh. This can include anything from positions, uvs, normals, colors etc..
    /// - Shader - This is the shader that PixiJS will render the geometry with (attributes in the shader must match the geometry)
    /// - State - This is the state of WebGL required to render the mesh.
    /// 
    /// Through a combination of the above elements you can render anything you want, 2D or 3D!
    type [<AllowNullLiteral>] MeshStatic =
        [<Emit "new $0($1...)">] abstract Create: geometry: PIXI.Geometry * shader: U2<PIXI.Shader, PIXI.MeshMaterial> * ?state: PIXI.State * ?drawMode: float -> Mesh
        /// The maximum number of vertices to consider batchable. Generally, the complexity
        /// of the geometry.
        abstract BATCHABLE_SIZE: float with get, set

    /// Class controls cache for UV mapping from Texture normal space to BaseTexture normal space.
    type [<AllowNullLiteral>] MeshBatchUvs =
        /// Buffer with normalized UV's
        abstract uvBuffer: PIXI.Buffer with get, set
        /// Material UV matrix
        abstract uvMatrix: PIXI.TextureMatrix with get, set
        /// UV Buffer data
        abstract data: float []
        /// <summary>updates</summary>
        /// <param name="forceUpdate">- force the update</param>
        abstract update: forceUpdate: bool -> unit

    /// Class controls cache for UV mapping from Texture normal space to BaseTexture normal space.
    type [<AllowNullLiteral>] MeshBatchUvsStatic =
        [<Emit "new $0($1...)">] abstract Create: uvBuffer: PIXI.Buffer * uvMatrix: PIXI.TextureMatrix -> MeshBatchUvs

    /// Standard 2D geometry used in PixiJS.
    /// 
    /// Geometry can be defined without passing in a style or data if required.
    /// 
    /// ```js
    /// const geometry = new PIXI.Geometry();
    /// 
    /// geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
    /// geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1], 2);
    /// geometry.addIndex([0,1,2,1,3,2]);
    /// 
    /// ```
    type [<AllowNullLiteral>] MeshGeometry =
        inherit PIXI.Geometry
        /// A map of renderer IDs to webgl VAOs
        abstract glVertexArrayObjects: obj option with get, set
        /// Count of existing (not destroyed) meshes that reference this geometry
        abstract refCount: float with get, set
        /// <summary>Adds an attribute to the geometry</summary>
        /// <param name="id">- the name of the attribute (matching up to a shader)</param>
        /// <param name="buffer">the buffer that holds the data of the attribute . You can also provide an Array and a buffer will be created from it.</param>
        /// <param name="size">the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2</param>
        /// <param name="normalized">should the data be normalized.</param>
        /// <param name="type">what type of number is the attribute. Check {PIXI.TYPES} to see the ones available</param>
        /// <param name="stride">How far apart (in floats) the start of each value is. (used for interleaving data)</param>
        /// <param name="start">How far into the array to start reading values (used for interleaving data)</param>
        abstract addAttribute: id: string * ?buffer: PIXI.Buffer * ?size: float * ?normalized: bool * ?``type``: float * ?stride: float * ?start: float -> PIXI.Geometry
        /// <summary>returns the requested attribute</summary>
        /// <param name="id">the name of the attribute required</param>
        abstract getAttribute: id: string -> PIXI.Attribute
        /// <summary>returns the requested buffer</summary>
        /// <param name="id">the name of the buffer required</param>
        abstract getBuffer: id: string -> PIXI.Buffer
        /// <summary>Adds an index buffer to the geometry
        /// The index buffer contains integers, three for each triangle in the geometry, which reference the various attribute buffers (position, colour, UV coordinates, other UV coordinates, normal, …). There is only ONE index buffer.</summary>
        /// <param name="buffer">the buffer that holds the data of the index buffer. You can also provide an Array and a buffer will be created from it.</param>
        abstract addIndex: ?buffer: PIXI.Buffer -> PIXI.Geometry
        /// returns the index buffer
        abstract getIndex: unit -> PIXI.Buffer
        /// this function modifies the structure so that all current attributes become interleaved into a single buffer
        /// This can be useful if your model remains static as it offers a little performance boost
        abstract interleave: unit -> PIXI.Geometry
        /// disposes WebGL resources that are connected to this geometry
        abstract dispose: unit -> unit
        /// Destroys the geometry.
        abstract destroy: unit -> unit
        /// returns a clone of the geometry
        abstract clone: unit -> PIXI.Geometry

    /// Standard 2D geometry used in PixiJS.
    /// 
    /// Geometry can be defined without passing in a style or data if required.
    /// 
    /// ```js
    /// const geometry = new PIXI.Geometry();
    /// 
    /// geometry.addAttribute('positions', [0, 0, 100, 0, 100, 100, 0, 100], 2);
    /// geometry.addAttribute('uvs', [0,0,1,0,1,1,0,1], 2);
    /// geometry.addIndex([0,1,2,1,3,2]);
    /// 
    /// ```
    type [<AllowNullLiteral>] MeshGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: vertices: U2<float [], ResizeArray<float>> * uvs: U2<float [], ResizeArray<float>> * index: U2<int [], ResizeArray<float>> -> MeshGeometry

    /// Slightly opinionated default shader for PixiJS 2D objects.
    type [<AllowNullLiteral>] MeshMaterial =
        inherit PIXI.Shader
        /// TextureMatrix instance for this Mesh, used to track Texture changes
        abstract uvMatrix: PIXI.TextureMatrix
        /// `true` if shader can be batch with the renderer's batch system.
        abstract batchable: bool with get, set
        /// Renderer plugin for batching
        abstract pluginName: string with get, set
        /// Reference to the texture being rendered.
        abstract texture: PIXI.Texture with get, set
        /// This gets automatically set by the object using this.
        abstract alpha: float with get, set
        /// Multiply tint for the material.
        abstract tint: float with get, set
        /// Gets called automatically by the Mesh. Intended to be overridden for custom
        /// MeshMaterial objects.
        abstract update: unit -> unit
        /// Shader uniform values, shortcut for `uniformGroup.uniforms`
        abstract uniforms: obj option

    /// Slightly opinionated default shader for PixiJS 2D objects.
    type [<AllowNullLiteral>] MeshMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: uSampler: PIXI.Texture * ?options: MeshMaterialStaticOptions -> MeshMaterial

    type [<AllowNullLiteral>] MeshMaterialStaticOptions =
        abstract alpha: float option with get, set
        abstract tint: float option with get, set
        abstract pluginName: string option with get, set
        abstract program: PIXI.Program option with get, set
        abstract uniforms: obj option with get, set

    /// RopeGeometry allows you to draw a geometry across several points and then manipulate these points.
    /// 
    /// ```js
    /// for (let i = 0; i < 20; i++) {
    ///      points.push(new PIXI.Point(i * 50, 0));
    /// };
    /// const rope = new PIXI.RopeGeometry(100, points);
    /// ```
    type [<AllowNullLiteral>] RopeGeometry =
        inherit PIXI.MeshGeometry
        /// An array of points that determine the rope
        abstract points: ResizeArray<PIXI.Point> with get, set
        /// The width (i.e., thickness) of the rope.
        abstract width: float
        /// refreshes vertices of Rope mesh
        abstract updateVertices: unit -> unit
        /// A map of renderer IDs to webgl VAOs
        abstract glVertexArrayObjects: obj option with get, set
        /// Count of existing (not destroyed) meshes that reference this geometry
        abstract refCount: float with get, set
        /// <summary>Adds an attribute to the geometry</summary>
        /// <param name="id">- the name of the attribute (matching up to a shader)</param>
        /// <param name="buffer">the buffer that holds the data of the attribute . You can also provide an Array and a buffer will be created from it.</param>
        /// <param name="size">the size of the attribute. If you have 2 floats per vertex (eg position x and y) this would be 2</param>
        /// <param name="normalized">should the data be normalized.</param>
        /// <param name="type">what type of number is the attribute. Check {PIXI.TYPES} to see the ones available</param>
        /// <param name="stride">How far apart (in floats) the start of each value is. (used for interleaving data)</param>
        /// <param name="start">How far into the array to start reading values (used for interleaving data)</param>
        abstract addAttribute: id: string * ?buffer: PIXI.Buffer * ?size: float * ?normalized: bool * ?``type``: float * ?stride: float * ?start: float -> PIXI.Geometry
        /// <summary>returns the requested attribute</summary>
        /// <param name="id">the name of the attribute required</param>
        abstract getAttribute: id: string -> PIXI.Attribute
        /// <summary>returns the requested buffer</summary>
        /// <param name="id">the name of the buffer required</param>
        abstract getBuffer: id: string -> PIXI.Buffer
        /// <summary>Adds an index buffer to the geometry
        /// The index buffer contains integers, three for each triangle in the geometry, which reference the various attribute buffers (position, colour, UV coordinates, other UV coordinates, normal, …). There is only ONE index buffer.</summary>
        /// <param name="buffer">the buffer that holds the data of the index buffer. You can also provide an Array and a buffer will be created from it.</param>
        abstract addIndex: ?buffer: PIXI.Buffer -> PIXI.Geometry
        /// returns the index buffer
        abstract getIndex: unit -> PIXI.Buffer
        /// this function modifies the structure so that all current attributes become interleaved into a single buffer
        /// This can be useful if your model remains static as it offers a little performance boost
        abstract interleave: unit -> PIXI.Geometry
        /// disposes WebGL resources that are connected to this geometry
        abstract dispose: unit -> unit
        /// Destroys the geometry.
        abstract destroy: unit -> unit
        /// returns a clone of the geometry
        abstract clone: unit -> PIXI.Geometry

    /// RopeGeometry allows you to draw a geometry across several points and then manipulate these points.
    /// 
    /// ```js
    /// for (let i = 0; i < 20; i++) {
    ///      points.push(new PIXI.Point(i * 50, 0));
    /// };
    /// const rope = new PIXI.RopeGeometry(100, points);
    /// ```
    type [<AllowNullLiteral>] RopeGeometryStatic =
        [<Emit "new $0($1...)">] abstract Create: ?width: float * ?points: ResizeArray<PIXI.Point> -> RopeGeometry

    /// The NineSlicePlane allows you to stretch a texture using 9-slice scaling. The corners will remain unscaled (useful
    /// for buttons with rounded corners for example) and the other areas will be scaled horizontally and or vertically
    /// 
    /// ```js
    /// let Plane9 = new PIXI.NineSlicePlane(PIXI.Texture.from('BoxWithRoundedCorners.png'), 15, 15, 15, 15);
    ///   ```
    /// <pre>
    ///       A                          B
    ///     +---+----------------------+---+
    ///   C | 1 |          2           | 3 |
    ///     +---+----------------------+---+
    ///     |   |                      |   |
    ///     | 4 |          5           | 6 |
    ///     |   |                      |   |
    ///     +---+----------------------+---+
    ///   D | 7 |          8           | 9 |
    ///     +---+----------------------+---+
    /// 
    ///   When changing this objects width and/or height:
    ///      areas 1 3 7 and 9 will remain unscaled.
    ///      areas 2 and 8 will be stretched horizontally
    ///      areas 4 and 6 will be stretched vertically
    ///      area 5 will be stretched both horizontally and vertically
    /// </pre>
    type [<AllowNullLiteral>] NineSlicePlane =
        inherit PIXI.SimplePlane
        /// The width of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane
        abstract _width: float with get, set
        /// The height of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane
        abstract _height: float with get, set
        /// Updates the horizontal vertices.
        abstract updateHorizontalVertices: unit -> unit
        /// Updates the vertical vertices.
        abstract updateVerticalVertices: unit -> unit
        /// The width of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane
        abstract width: float with get, set
        /// The height of the NineSlicePlane, setting this will actually modify the vertices and UV's of this plane
        abstract height: float with get, set
        /// The width of the left column
        abstract leftWidth: float with get, set
        /// The width of the right column
        abstract rightWidth: float with get, set
        /// The height of the top row
        abstract topHeight: float with get, set
        /// The height of the bottom row
        abstract bottomHeight: float with get, set
        /// Refreshes NineSlicePlane coords. All of them.
        abstract _refresh: unit -> unit
        /// Method used for overrides, to do something in case texture frame was changed.
        /// Meshes based on plane can override it and change more details based on texture.
        abstract textureUpdated: unit -> unit
        /// Includes vertex positions, face indices, normals, colors, UVs, and
        /// custom attributes within buffers, reducing the cost of passing all
        /// this data to the GPU. Can be shared between multiple Mesh objects.
        abstract geometry: PIXI.Geometry
        /// Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
        /// Can be shared between multiple Mesh objects.
        abstract shader: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// Represents the WebGL state the Mesh required to render, excludes shader and geometry. E.g.,
        /// blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
        abstract state: PIXI.State with get, set
        /// The way the Mesh should be drawn, can be any of the {@link PIXI.DRAW_MODES} constants.
        abstract drawMode: float with get, set
        /// Typically the index of the IndexBuffer where to start drawing.
        abstract start: float with get, set
        /// How much of the geometry to draw, by default `0` renders everything.
        abstract size: float with get, set
        /// To change mesh uv's, change its uvBuffer data and increment its _updateID.
        abstract uvBuffer: PIXI.Buffer
        /// To change mesh vertices, change its uvBuffer data and increment its _updateID.
        /// Incrementing _updateID is optional because most of Mesh objects do it anyway.
        abstract verticesBuffer: PIXI.Buffer
        /// Alias for {@link PIXI.Mesh#shader}.
        abstract material: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// The blend mode to be applied to the Mesh. Apply a value of
        /// `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The multiply tint applied to the Mesh. This is a hex value. A value of
        /// `0xFFFFFF` will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the Mesh uses.
        abstract texture: PIXI.Texture with get, set
        /// Standard renderer draw.
        abstract _render: unit -> unit
        /// <summary>Standard non-batching way of rendering.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderDefault: renderer: PIXI.Renderer -> unit
        /// <summary>Rendering by using the Batch system.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderToBatch: renderer: PIXI.Renderer -> unit
        /// Updates vertexData field based on transform and vertices
        abstract calculateVertices: unit -> unit
        /// Updates uv field based on from geometry uv's or batchUvs
        abstract calculateUvs: unit -> unit
        /// Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
        /// there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
        abstract _calculateBounds: unit -> unit
        /// <summary>Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.</summary>
        /// <param name="point">the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys the Mesh object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: NineSlicePlaneDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] NineSlicePlaneDestroyOptions =
        abstract children: bool option with get, set

    /// The NineSlicePlane allows you to stretch a texture using 9-slice scaling. The corners will remain unscaled (useful
    /// for buttons with rounded corners for example) and the other areas will be scaled horizontally and or vertically
    /// 
    /// ```js
    /// let Plane9 = new PIXI.NineSlicePlane(PIXI.Texture.from('BoxWithRoundedCorners.png'), 15, 15, 15, 15);
    ///   ```
    /// <pre>
    ///       A                          B
    ///     +---+----------------------+---+
    ///   C | 1 |          2           | 3 |
    ///     +---+----------------------+---+
    ///     |   |                      |   |
    ///     | 4 |          5           | 6 |
    ///     |   |                      |   |
    ///     +---+----------------------+---+
    ///   D | 7 |          8           | 9 |
    ///     +---+----------------------+---+
    /// 
    ///   When changing this objects width and/or height:
    ///      areas 1 3 7 and 9 will remain unscaled.
    ///      areas 2 and 8 will be stretched horizontally
    ///      areas 4 and 6 will be stretched vertically
    ///      area 5 will be stretched both horizontally and vertically
    /// </pre>
    type [<AllowNullLiteral>] NineSlicePlaneStatic =
        [<Emit "new $0($1...)">] abstract Create: texture: PIXI.Texture * ?leftWidth: float * ?topHeight: float * ?rightWidth: float * ?bottomHeight: float -> NineSlicePlane

    /// The Simple Mesh class mimics Mesh in PixiJS v4, providing easy-to-use constructor arguments.
    /// For more robust customization, use {@link PIXI.Mesh}.
    type [<AllowNullLiteral>] SimpleMesh =
        inherit PIXI.Mesh
        /// upload vertices buffer each frame
        abstract autoUpdate: bool with get, set
        /// Collection of vertices data.
        abstract vertices: float [] with get, set
        /// Includes vertex positions, face indices, normals, colors, UVs, and
        /// custom attributes within buffers, reducing the cost of passing all
        /// this data to the GPU. Can be shared between multiple Mesh objects.
        abstract geometry: PIXI.Geometry
        /// Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
        /// Can be shared between multiple Mesh objects.
        abstract shader: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// Represents the WebGL state the Mesh required to render, excludes shader and geometry. E.g.,
        /// blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
        abstract state: PIXI.State with get, set
        /// The way the Mesh should be drawn, can be any of the {@link PIXI.DRAW_MODES} constants.
        abstract drawMode: float with get, set
        /// Typically the index of the IndexBuffer where to start drawing.
        abstract start: float with get, set
        /// How much of the geometry to draw, by default `0` renders everything.
        abstract size: float with get, set
        /// To change mesh uv's, change its uvBuffer data and increment its _updateID.
        abstract uvBuffer: PIXI.Buffer
        /// To change mesh vertices, change its uvBuffer data and increment its _updateID.
        /// Incrementing _updateID is optional because most of Mesh objects do it anyway.
        abstract verticesBuffer: PIXI.Buffer
        /// Alias for {@link PIXI.Mesh#shader}.
        abstract material: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// The blend mode to be applied to the Mesh. Apply a value of
        /// `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The multiply tint applied to the Mesh. This is a hex value. A value of
        /// `0xFFFFFF` will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the Mesh uses.
        abstract texture: PIXI.Texture with get, set
        /// Standard renderer draw.
        abstract _render: unit -> unit
        /// <summary>Standard non-batching way of rendering.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderDefault: renderer: PIXI.Renderer -> unit
        /// <summary>Rendering by using the Batch system.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderToBatch: renderer: PIXI.Renderer -> unit
        /// Updates vertexData field based on transform and vertices
        abstract calculateVertices: unit -> unit
        /// Updates uv field based on from geometry uv's or batchUvs
        abstract calculateUvs: unit -> unit
        /// Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
        /// there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
        abstract _calculateBounds: unit -> unit
        /// <summary>Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.</summary>
        /// <param name="point">the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys the Mesh object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: SimpleMeshDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] SimpleMeshDestroyOptions =
        abstract children: bool option with get, set

    /// The Simple Mesh class mimics Mesh in PixiJS v4, providing easy-to-use constructor arguments.
    /// For more robust customization, use {@link PIXI.Mesh}.
    type [<AllowNullLiteral>] SimpleMeshStatic =
        [<Emit "new $0($1...)">] abstract Create: ?texture: PIXI.Texture * ?vertices: float [] * ?uvs: float [] * ?indices: int [] * ?drawMode: float -> SimpleMesh

    /// The SimplePlane allows you to draw a texture across several points and then manipulate these points
    /// 
    /// ```js
    /// for (let i = 0; i < 20; i++) {
    ///      points.push(new PIXI.Point(i * 50, 0));
    /// };
    /// let SimplePlane = new PIXI.SimplePlane(PIXI.Texture.from("snake.png"), points);
    ///   ```
    type [<AllowNullLiteral>] SimplePlane =
        inherit PIXI.Mesh
        /// Method used for overrides, to do something in case texture frame was changed.
        /// Meshes based on plane can override it and change more details based on texture.
        abstract textureUpdated: unit -> unit
        /// Includes vertex positions, face indices, normals, colors, UVs, and
        /// custom attributes within buffers, reducing the cost of passing all
        /// this data to the GPU. Can be shared between multiple Mesh objects.
        abstract geometry: PIXI.Geometry
        /// Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
        /// Can be shared between multiple Mesh objects.
        abstract shader: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// Represents the WebGL state the Mesh required to render, excludes shader and geometry. E.g.,
        /// blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
        abstract state: PIXI.State with get, set
        /// The way the Mesh should be drawn, can be any of the {@link PIXI.DRAW_MODES} constants.
        abstract drawMode: float with get, set
        /// Typically the index of the IndexBuffer where to start drawing.
        abstract start: float with get, set
        /// How much of the geometry to draw, by default `0` renders everything.
        abstract size: float with get, set
        /// To change mesh uv's, change its uvBuffer data and increment its _updateID.
        abstract uvBuffer: PIXI.Buffer
        /// To change mesh vertices, change its uvBuffer data and increment its _updateID.
        /// Incrementing _updateID is optional because most of Mesh objects do it anyway.
        abstract verticesBuffer: PIXI.Buffer
        /// Alias for {@link PIXI.Mesh#shader}.
        abstract material: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// The blend mode to be applied to the Mesh. Apply a value of
        /// `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The multiply tint applied to the Mesh. This is a hex value. A value of
        /// `0xFFFFFF` will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the Mesh uses.
        abstract texture: PIXI.Texture with get, set
        /// Standard renderer draw.
        abstract _render: unit -> unit
        /// <summary>Standard non-batching way of rendering.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderDefault: renderer: PIXI.Renderer -> unit
        /// <summary>Rendering by using the Batch system.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderToBatch: renderer: PIXI.Renderer -> unit
        /// Updates vertexData field based on transform and vertices
        abstract calculateVertices: unit -> unit
        /// Updates uv field based on from geometry uv's or batchUvs
        abstract calculateUvs: unit -> unit
        /// Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
        /// there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
        abstract _calculateBounds: unit -> unit
        /// <summary>Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.</summary>
        /// <param name="point">the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys the Mesh object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: SimplePlaneDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] SimplePlaneDestroyOptions =
        abstract children: bool option with get, set

    /// The SimplePlane allows you to draw a texture across several points and then manipulate these points
    /// 
    /// ```js
    /// for (let i = 0; i < 20; i++) {
    ///      points.push(new PIXI.Point(i * 50, 0));
    /// };
    /// let SimplePlane = new PIXI.SimplePlane(PIXI.Texture.from("snake.png"), points);
    ///   ```
    type [<AllowNullLiteral>] SimplePlaneStatic =
        [<Emit "new $0($1...)">] abstract Create: texture: PIXI.Texture * verticesX: float * verticesY: float -> SimplePlane

    /// The rope allows you to draw a texture across several points and then manipulate these points
    /// 
    /// ```js
    /// for (let i = 0; i < 20; i++) {
    ///      points.push(new PIXI.Point(i * 50, 0));
    /// };
    /// let rope = new PIXI.Rope(PIXI.Texture.from("snake.png"), points);
    ///   ```
    type [<AllowNullLiteral>] SimpleRope =
        inherit PIXI.Mesh
        /// re-calculate vertices by rope points each frame
        abstract autoUpdate: bool with get, set
        /// Includes vertex positions, face indices, normals, colors, UVs, and
        /// custom attributes within buffers, reducing the cost of passing all
        /// this data to the GPU. Can be shared between multiple Mesh objects.
        abstract geometry: PIXI.Geometry
        /// Represents the vertex and fragment shaders that processes the geometry and runs on the GPU.
        /// Can be shared between multiple Mesh objects.
        abstract shader: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// Represents the WebGL state the Mesh required to render, excludes shader and geometry. E.g.,
        /// blend mode, culling, depth testing, direction of rendering triangles, backface, etc.
        abstract state: PIXI.State with get, set
        /// The way the Mesh should be drawn, can be any of the {@link PIXI.DRAW_MODES} constants.
        abstract drawMode: float with get, set
        /// Typically the index of the IndexBuffer where to start drawing.
        abstract start: float with get, set
        /// How much of the geometry to draw, by default `0` renders everything.
        abstract size: float with get, set
        /// To change mesh uv's, change its uvBuffer data and increment its _updateID.
        abstract uvBuffer: PIXI.Buffer
        /// To change mesh vertices, change its uvBuffer data and increment its _updateID.
        /// Incrementing _updateID is optional because most of Mesh objects do it anyway.
        abstract verticesBuffer: PIXI.Buffer
        /// Alias for {@link PIXI.Mesh#shader}.
        abstract material: U2<PIXI.Shader, PIXI.MeshMaterial> with get, set
        /// The blend mode to be applied to the Mesh. Apply a value of
        /// `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The multiply tint applied to the Mesh. This is a hex value. A value of
        /// `0xFFFFFF` will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the Mesh uses.
        abstract texture: PIXI.Texture with get, set
        /// Standard renderer draw.
        abstract _render: unit -> unit
        /// <summary>Standard non-batching way of rendering.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderDefault: renderer: PIXI.Renderer -> unit
        /// <summary>Rendering by using the Batch system.</summary>
        /// <param name="renderer">- Instance to renderer.</param>
        abstract _renderToBatch: renderer: PIXI.Renderer -> unit
        /// Updates vertexData field based on transform and vertices
        abstract calculateVertices: unit -> unit
        /// Updates uv field based on from geometry uv's or batchUvs
        abstract calculateUvs: unit -> unit
        /// Updates the bounds of the mesh as a rectangle. The bounds calculation takes the worldTransform into account.
        /// there must be a aVertexPosition attribute present in the geometry for bounds to be calculated correctly.
        abstract _calculateBounds: unit -> unit
        /// <summary>Tests if a point is inside this mesh. Works only for PIXI.DRAW_MODES.TRIANGLES.</summary>
        /// <param name="point">the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys the Mesh object.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all
        /// options have been set to that value</param>
        abstract destroy: ?options: SimpleRopeDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] SimpleRopeDestroyOptions =
        abstract children: bool option with get, set

    /// The rope allows you to draw a texture across several points and then manipulate these points
    /// 
    /// ```js
    /// for (let i = 0; i < 20; i++) {
    ///      points.push(new PIXI.Point(i * 50, 0));
    /// };
    /// let rope = new PIXI.Rope(PIXI.Texture.from("snake.png"), points);
    ///   ```
    type [<AllowNullLiteral>] SimpleRopeStatic =
        [<Emit "new $0($1...)">] abstract Create: texture: PIXI.Texture * points: ResizeArray<PIXI.Point> -> SimpleRope

    /// The ParticleContainer class is a really fast version of the Container built solely for speed,
    /// so use when you need a lot of sprites or particles.
    /// 
    /// The tradeoff of the ParticleContainer is that most advanced functionality will not work.
    /// ParticleContainer implements the basic object transform (position, scale, rotation)
    /// and some advanced functionality like tint (as of v4.5.6).
    /// 
    /// Other more advanced functionality like masking, children, filters, etc will not work on sprites in this batch.
    /// 
    /// It's extremely easy to use:
    /// ```js
    /// let container = new ParticleContainer();
    /// 
    /// for (let i = 0; i < 100; ++i)
    /// {
    ///      let sprite = PIXI.Sprite.from("myImage.png");
    ///      container.addChild(sprite);
    /// }
    /// ```
    /// 
    /// And here you have a hundred sprites that will be rendered at the speed of light.
    type [<AllowNullLiteral>] ParticleContainer =
        inherit PIXI.Container
        abstract interactiveChildren: bool with get, set
        /// The blend mode to be applied to the sprite. Apply a value of `PIXI.BLEND_MODES.NORMAL`
        /// to reset the blend mode.
        abstract blendMode: float with get, set
        /// If true, container allocates more batches in case there are more than `maxSize` particles.
        abstract autoResize: bool with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// Default to true here as performance is usually the priority for particles.
        abstract roundPixels: bool with get, set
        /// The texture used to render the children.
        abstract baseTexture: PIXI.BaseTexture
        /// <summary>Sets the private properties array to dynamic / static based on the passed properties object</summary>
        /// <param name="properties">- The properties to be uploaded</param>
        abstract setProperties: properties: obj option -> unit
        /// The tint applied to the container. This is a hex value.
        /// A value of 0xFFFFFF will remove any tint effect.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        abstract tint: float with get, set
        /// <summary>Destroys the container</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?options: ParticleContainerDestroyOptions -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// Recalculates the bounds of the object. Override this to
        /// calculate the bounds of the specific object (not including children).
        abstract _calculateBounds: unit -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// <summary>To be overridden by the subclasses.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Retrieves the local bounds of the displayObject as a rectangle object.</summary>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] ParticleContainerDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// The ParticleContainer class is a really fast version of the Container built solely for speed,
    /// so use when you need a lot of sprites or particles.
    /// 
    /// The tradeoff of the ParticleContainer is that most advanced functionality will not work.
    /// ParticleContainer implements the basic object transform (position, scale, rotation)
    /// and some advanced functionality like tint (as of v4.5.6).
    /// 
    /// Other more advanced functionality like masking, children, filters, etc will not work on sprites in this batch.
    /// 
    /// It's extremely easy to use:
    /// ```js
    /// let container = new ParticleContainer();
    /// 
    /// for (let i = 0; i < 100; ++i)
    /// {
    ///      let sprite = PIXI.Sprite.from("myImage.png");
    ///      container.addChild(sprite);
    /// }
    /// ```
    /// 
    /// And here you have a hundred sprites that will be rendered at the speed of light.
    type [<AllowNullLiteral>] ParticleContainerStatic =
        [<Emit "new $0($1...)">] abstract Create: ?maxSize: float * ?properties: ParticleContainerStaticProperties * ?batchSize: float * ?autoResize: bool -> ParticleContainer

    type [<AllowNullLiteral>] ParticleContainerStaticProperties =
        abstract vertices: bool option with get, set
        abstract position: bool option with get, set
        abstract rotation: bool option with get, set
        abstract uvs: bool option with get, set
        abstract tint: bool option with get, set

    /// Renderer for Particles that is designer for speed over feature set.
    type [<AllowNullLiteral>] ParticleRenderer =
        /// The default shader that is used if a sprite doesn't have a more specific one.
        abstract shader: PIXI.Shader with get, set
        /// <summary>Renders the particle container object.</summary>
        /// <param name="container">- The container to render using this ParticleRenderer</param>
        abstract render: container: PIXI.ParticleContainer -> unit
        /// <summary>Uploads the vertices.</summary>
        /// <param name="children">- the array of display objects to render</param>
        /// <param name="startIndex">- the index to start from in the children array</param>
        /// <param name="amount">- the amount of children that will have their vertices uploaded</param>
        /// <param name="array">- The vertices to upload.</param>
        /// <param name="stride">- Stride to use for iteration.</param>
        /// <param name="offset">- Offset to start at.</param>
        abstract uploadVertices: children: ResizeArray<PIXI.DisplayObject> * startIndex: float * amount: float * array: ResizeArray<float> * stride: float * offset: float -> unit
        /// <summary>Uploads the position.</summary>
        /// <param name="children">- the array of display objects to render</param>
        /// <param name="startIndex">- the index to start from in the children array</param>
        /// <param name="amount">- the amount of children that will have their positions uploaded</param>
        /// <param name="array">- The vertices to upload.</param>
        /// <param name="stride">- Stride to use for iteration.</param>
        /// <param name="offset">- Offset to start at.</param>
        abstract uploadPosition: children: ResizeArray<PIXI.DisplayObject> * startIndex: float * amount: float * array: ResizeArray<float> * stride: float * offset: float -> unit
        /// <summary>Uploads the rotiation.</summary>
        /// <param name="children">- the array of display objects to render</param>
        /// <param name="startIndex">- the index to start from in the children array</param>
        /// <param name="amount">- the amount of children that will have their rotation uploaded</param>
        /// <param name="array">- The vertices to upload.</param>
        /// <param name="stride">- Stride to use for iteration.</param>
        /// <param name="offset">- Offset to start at.</param>
        abstract uploadRotation: children: ResizeArray<PIXI.DisplayObject> * startIndex: float * amount: float * array: ResizeArray<float> * stride: float * offset: float -> unit
        /// <summary>Uploads the Uvs</summary>
        /// <param name="children">- the array of display objects to render</param>
        /// <param name="startIndex">- the index to start from in the children array</param>
        /// <param name="amount">- the amount of children that will have their rotation uploaded</param>
        /// <param name="array">- The vertices to upload.</param>
        /// <param name="stride">- Stride to use for iteration.</param>
        /// <param name="offset">- Offset to start at.</param>
        abstract uploadUvs: children: ResizeArray<PIXI.DisplayObject> * startIndex: float * amount: float * array: ResizeArray<float> * stride: float * offset: float -> unit
        /// <summary>Uploads the tint.</summary>
        /// <param name="children">- the array of display objects to render</param>
        /// <param name="startIndex">- the index to start from in the children array</param>
        /// <param name="amount">- the amount of children that will have their rotation uploaded</param>
        /// <param name="array">- The vertices to upload.</param>
        /// <param name="stride">- Stride to use for iteration.</param>
        /// <param name="offset">- Offset to start at.</param>
        abstract uploadTint: children: ResizeArray<PIXI.DisplayObject> * startIndex: float * amount: float * array: ResizeArray<float> * stride: float * offset: float -> unit
        /// Destroys the ParticleRenderer.
        abstract destroy: unit -> unit

    /// Renderer for Particles that is designer for speed over feature set.
    type [<AllowNullLiteral>] ParticleRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> ParticleRenderer

    module Prepare =

        type [<AllowNullLiteral>] IExports =
            abstract WebGLPrepare: WebGLPrepareStatic
            abstract BasePrepare: BasePrepareStatic
            abstract CountLimiter: CountLimiterStatic
            abstract Prepare: PrepareStatic
            abstract TimeLimiter: TimeLimiterStatic

        type [<AllowNullLiteral>] WebGLPrepare =
            interface end

        type [<AllowNullLiteral>] WebGLPrepareStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WebGLPrepare

        /// The prepare manager provides functionality to upload content to the GPU.
        /// 
        /// BasePrepare handles basic queuing functionality and is extended by
        /// {@link PIXI.prepare.Prepare} and {@link PIXI.prepare.CanvasPrepare}
        /// to provide preparation capabilities specific to their respective renderers.
        type [<AllowNullLiteral>] BasePrepare =
            /// The limiter to be used to control how quickly items are prepared.
            abstract limiter: U2<PIXI.Prepare.CountLimiter, PIXI.Prepare.TimeLimiter> with get, set
            /// Reference to the renderer.
            abstract renderer: PIXI.AbstractRenderer with get, set
            /// The only real difference between CanvasPrepare and Prepare is what they pass
            /// to upload hooks. That different parameter is stored here.
            abstract uploadHookHelper: PIXI.Renderer with get, set
            /// <summary>Upload all the textures and graphics to the GPU.</summary>
            /// <param name="item">-
            /// Either the container or display object to search for items to upload, the items to upload themselves,
            /// or the callback function, if items have been added using `prepare.add`.</param>
            /// <param name="done">- Optional callback when all queued uploads have completed</param>
            abstract upload: item: U7<(ResizeArray<obj option> -> obj option), PIXI.DisplayObject, PIXI.Container, PIXI.BaseTexture, PIXI.Texture, PIXI.Graphics, PIXI.Text> * ?``done``: (ResizeArray<obj option> -> obj option) -> unit
            /// <summary>Adds hooks for finding items.</summary>
            /// <param name="addHook">- (unit->unit) call that takes two parameters: `item:*, queue:Array`
            /// function must return `true` if it was able to add item to the queue.</param>
            abstract registerFindHook: addHook: (ResizeArray<obj option> -> obj option) -> PIXI.Prepare.BasePrepare
            /// <summary>Adds hooks for uploading items.</summary>
            /// <param name="uploadHook">- (unit->unit) call that takes two parameters: `prepare:CanvasPrepare, item:*` and
            /// function must return `true` if it was able to handle upload of item.</param>
            abstract registerUploadHook: uploadHook: (ResizeArray<obj option> -> obj option) -> PIXI.Prepare.BasePrepare
            /// <summary>Manually add an item to the uploading queue.</summary>
            /// <param name="item">- Object to
            /// add to the queue</param>
            abstract add: item: U7<PIXI.DisplayObject, PIXI.Container, PIXI.BaseTexture, PIXI.Texture, PIXI.Graphics, PIXI.Text, obj option> -> PIXI.Prepare.BasePrepare
            /// Destroys the plugin, don't use after this.
            abstract destroy: unit -> unit

        /// The prepare manager provides functionality to upload content to the GPU.
        /// 
        /// BasePrepare handles basic queuing functionality and is extended by
        /// {@link PIXI.prepare.Prepare} and {@link PIXI.prepare.CanvasPrepare}
        /// to provide preparation capabilities specific to their respective renderers.
        type [<AllowNullLiteral>] BasePrepareStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.AbstractRenderer -> BasePrepare

        /// CountLimiter limits the number of items handled by a {@link PIXI.prepare.BasePrepare} to a specified
        /// number of items per frame.
        type [<AllowNullLiteral>] CountLimiter =
            /// Resets any counting properties to start fresh on a new frame.
            abstract beginFrame: unit -> unit
            /// Checks to see if another item can be uploaded. This should only be called once per item.
            abstract allowedToUpload: unit -> bool

        /// CountLimiter limits the number of items handled by a {@link PIXI.prepare.BasePrepare} to a specified
        /// number of items per frame.
        type [<AllowNullLiteral>] CountLimiterStatic =
            [<Emit "new $0($1...)">] abstract Create: maxItemsPerFrame: float -> CountLimiter

        /// The prepare manager provides functionality to upload content to the GPU.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.prepare`
        type [<AllowNullLiteral>] Prepare =
            inherit PIXI.Prepare.BasePrepare
            /// The limiter to be used to control how quickly items are prepared.
            abstract limiter: U2<PIXI.Prepare.CountLimiter, PIXI.Prepare.TimeLimiter> with get, set
            /// Reference to the renderer.
            abstract renderer: PIXI.AbstractRenderer with get, set
            /// The only real difference between CanvasPrepare and Prepare is what they pass
            /// to upload hooks. That different parameter is stored here.
            abstract uploadHookHelper: PIXI.Renderer with get, set
            /// <summary>Upload all the textures and graphics to the GPU.</summary>
            /// <param name="item">-
            /// Either the container or display object to search for items to upload, the items to upload themselves,
            /// or the callback function, if items have been added using `prepare.add`.</param>
            /// <param name="done">- Optional callback when all queued uploads have completed</param>
            abstract upload: item: U7<(ResizeArray<obj option> -> obj option), PIXI.DisplayObject, PIXI.Container, PIXI.BaseTexture, PIXI.Texture, PIXI.Graphics, PIXI.Text> * ?``done``: (ResizeArray<obj option> -> obj option) -> unit
            /// <summary>Adds hooks for finding items.</summary>
            /// <param name="addHook">- (unit->unit) call that takes two parameters: `item:*, queue:Array`
            /// function must return `true` if it was able to add item to the queue.</param>
            abstract registerFindHook: addHook: (ResizeArray<obj option> -> obj option) -> PIXI.Prepare.BasePrepare
            /// <summary>Adds hooks for uploading items.</summary>
            /// <param name="uploadHook">- (unit->unit) call that takes two parameters: `prepare:CanvasPrepare, item:*` and
            /// function must return `true` if it was able to handle upload of item.</param>
            abstract registerUploadHook: uploadHook: (ResizeArray<obj option> -> obj option) -> PIXI.Prepare.BasePrepare
            /// <summary>Manually add an item to the uploading queue.</summary>
            /// <param name="item">- Object to
            /// add to the queue</param>
            abstract add: item: U7<PIXI.DisplayObject, PIXI.Container, PIXI.BaseTexture, PIXI.Texture, PIXI.Graphics, PIXI.Text, obj option> -> PIXI.Prepare.BasePrepare
            /// Destroys the plugin, don't use after this.
            abstract destroy: unit -> unit

        /// The prepare manager provides functionality to upload content to the GPU.
        /// 
        /// An instance of this class is automatically created by default, and can be found at `renderer.plugins.prepare`
        type [<AllowNullLiteral>] PrepareStatic =
            [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> Prepare

        /// TimeLimiter limits the number of items handled by a {@link PIXI.BasePrepare} to a specified
        /// number of milliseconds per frame.
        type [<AllowNullLiteral>] TimeLimiter =
            /// Resets any counting properties to start fresh on a new frame.
            abstract beginFrame: unit -> unit
            /// Checks to see if another item can be uploaded. This should only be called once per item.
            abstract allowedToUpload: unit -> bool

        /// TimeLimiter limits the number of items handled by a {@link PIXI.BasePrepare} to a specified
        /// number of milliseconds per frame.
        type [<AllowNullLiteral>] TimeLimiterStatic =
            [<Emit "new $0($1...)">] abstract Create: maxMilliseconds: float -> TimeLimiter

    /// A Runner is a highly performant and simple alternative to signals. Best used in situations
    /// where events are dispatched to many objects at high frequency (say every frame!)
    /// 
    /// 
    /// like a signal..
    /// ```
    /// const myObject = {
    ///      loaded: new PIXI.Runner('loaded')
    /// }
    /// 
    /// const listener = {
    ///      loaded: function(){
    ///          // thin
    ///      }
    /// }
    /// 
    /// myObject.update.add(listener);
    /// 
    /// myObject.loaded.emit();
    /// ```
    /// 
    /// Or for handling calling the same function on many items
    /// ```
    /// const myGame = {
    ///      update: new PIXI.Runner('update')
    /// }
    /// 
    /// const gameObject = {
    ///      update: function(time){
    ///          // update my gamey state
    ///      }
    /// }
    /// 
    /// myGame.update.add(gameObject1);
    /// 
    /// myGame.update.emit(time);
    /// ```
    type [<AllowNullLiteral>] Runner =
        /// <summary>Dispatch/Broadcast Runner to all listeners added to the queue.</summary>
        /// <param name="params">- optional parameters to pass to each listener</param>
        abstract emit: [<ParamArray>] ``params``: ResizeArray<obj option> -> unit
        /// <summary>Add a listener to the Runner
        /// 
        /// Runners do not need to have scope or functions passed to them.
        /// All that is required is to pass the listening object and ensure that it has contains a function that has the same name
        /// as the name provided to the Runner when it was created.
        /// 
        /// Eg A listener passed to this Runner will require a 'complete' function.
        /// 
        /// ```
        /// const complete = new PIXI.Runner('complete');
        /// ```
        /// 
        /// The scope used will be the object itself.</summary>
        /// <param name="item">- The object that will be listening.</param>
        abstract add: item: obj option -> unit
        /// <summary>Remove a single listener from the dispatch queue.</summary>
        /// <param name="item">- The listenr that you would like to remove.</param>
        abstract remove: item: obj option -> unit
        /// <summary>Check to see if the listener is already in the Runner</summary>
        /// <param name="item">- The listener that you would like to check.</param>
        abstract contains: item: obj option -> unit
        /// Remove all listeners from the Runner
        abstract removeAll: unit -> unit
        /// Remove all references, don't use after this.
        abstract destroy: unit -> unit
        /// `true` if there are no this Runner contains no listeners
        abstract empty: bool
        /// The name of the runner.
        abstract name: string
        /// Alias for `emit`
        abstract dispatch: unit -> unit
        /// Alias for `emit`
        abstract run: unit -> unit

    /// A Runner is a highly performant and simple alternative to signals. Best used in situations
    /// where events are dispatched to many objects at high frequency (say every frame!)
    /// 
    /// 
    /// like a signal..
    /// ```
    /// const myObject = {
    ///      loaded: new PIXI.Runner('loaded')
    /// }
    /// 
    /// const listener = {
    ///      loaded: function(){
    ///          // thin
    ///      }
    /// }
    /// 
    /// myObject.update.add(listener);
    /// 
    /// myObject.loaded.emit();
    /// ```
    /// 
    /// Or for handling calling the same function on many items
    /// ```
    /// const myGame = {
    ///      update: new PIXI.Runner('update')
    /// }
    /// 
    /// const gameObject = {
    ///      update: function(time){
    ///          // update my gamey state
    ///      }
    /// }
    /// 
    /// myGame.update.add(gameObject1);
    /// 
    /// myGame.update.emit(time);
    /// ```
    type [<AllowNullLiteral>] RunnerStatic =
        [<Emit "new $0($1...)">] abstract Create: name: string -> Runner

    module Settings =

        type [<AllowNullLiteral>] IExports =
            abstract TRANSFORM_MODE: PIXI.TRANSFORM_MODE
            abstract PREFER_ENV: float
            abstract SORTABLE_CHILDREN: bool
            abstract UPLOADS_PER_FRAME: float
            abstract MIPMAP_TEXTURES: PIXI.MIPMAP_MODES
            abstract ANISOTROPIC_LEVEL: float
            abstract RESOLUTION: float
            abstract FILTER_RESOLUTION: float
            abstract SPRITE_MAX_TEXTURES: float
            abstract SPRITE_BATCH_SIZE: float
            abstract RENDER_OPTIONS: TypeLiteral_04
            abstract GC_MODE: PIXI.GC_MODES
            abstract GC_MAX_IDLE: float
            abstract GC_MAX_CHECK_COUNT: float
            abstract WRAP_MODE: PIXI.WRAP_MODES
            abstract SCALE_MODE: PIXI.SCALE_MODES
            abstract PRECISION_VERTEX: PIXI.PRECISION
            abstract PRECISION_FRAGMENT: PIXI.PRECISION
            abstract CAN_UPLOAD_SAME_BUFFER: bool
            abstract CREATE_IMAGE_BITMAP: bool
            abstract ROUND_PIXELS: bool
            abstract TARGET_FPMS: float
            // TODO abstract RETINA_PREFIX: RegExp

        type [<AllowNullLiteral>] TypeLiteral_04 =
            abstract view: Browser.Types.HTMLCanvasElement with get, set
            abstract resolution: float with get, set
            abstract antialias: bool with get, set
            abstract forceFXAA: bool with get, set
            abstract autoDensity: bool with get, set
            abstract transparent: bool with get, set
            abstract backgroundColor: float with get, set
            abstract clearBeforeRender: bool with get, set
            abstract preserveDrawingBuffer: bool with get, set
            abstract width: float with get, set
            abstract height: float with get, set
            abstract legacy: bool with get, set

    /// The Sprite object is the base for all textured objects that are rendered to the screen
    /// 
    /// A sprite can be created directly from an image like this:
    /// 
    /// ```js
    /// let sprite = PIXI.Sprite.from('assets/image.png');
    /// ```
    /// 
    /// The more efficient way to create sprites is using a {@link PIXI.Spritesheet},
    /// as swapping base textures when rendering to the screen is inefficient.
    /// 
    /// ```js
    /// PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
    /// 
    /// function setup() {
    ///    let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
    ///    let sprite = new PIXI.Sprite(sheet.textures["image.png"]);
    ///    ...
    /// }
    /// ```
    type [<AllowNullLiteral>] Sprite =
        inherit PIXI.Container
        /// The blend mode to be applied to the sprite. Apply a value of `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// The shader that will be used to render the sprite. Set to null to remove a current shader.
        abstract shader: U2<PIXI.Filter, PIXI.Shader> with get, set
        /// Cached tint value so we can tell when the tint is changed.
        /// Value is used for 2d CanvasRenderer.
        abstract _cachedTint: float with get, set
        /// Plugin that is responsible for rendering this element.
        /// Allows to customize the rendering process without overriding '_render' & '_renderCanvas' methods.
        abstract pluginName: string with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        /// calculates worldTransform * vertices, store it in vertexData
        abstract calculateVertices: unit -> unit
        /// calculates worldTransform * vertices for a non texture with a trim. store it in vertexTrimmedData
        /// This is used to ensure that the true width and height of a trimmed texture is respected
        abstract calculateTrimmedVertices: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The webgl renderer to use.</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// Updates the bounds of the sprite.
        abstract _calculateBounds: unit -> unit
        /// <summary>Gets the local bounds of the sprite object.</summary>
        /// <param name="rect">- The output rectangle.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Tests if a point is inside this sprite</summary>
        /// <param name="point">- the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys this sprite and optionally its texture and children</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?options: SpriteDestroyOptions -> unit
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The width of the sprite, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the sprite, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// The anchor sets the origin point of the text. The default value is taken from the {@link PIXI.Texture|Texture}
        /// and passed to the constructor.
        /// 
        /// The default is `(0,0)`, this means the text's origin is the top left.
        /// 
        /// Setting the anchor to `(0.5,0.5)` means the text's origin is centered.
        /// 
        /// Setting the anchor to `(1,1)` would mean the text's origin point will be the bottom right corner.
        /// 
        /// If you pass only single parameter, it will set both x and y to the same value as shown in the example below.
        abstract anchor: PIXI.ObservablePoint with get, set
        /// The tint applied to the sprite. This is a hex value.
        /// A value of 0xFFFFFF will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the sprite is using
        abstract texture: PIXI.Texture with get, set
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] SpriteDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// The Sprite object is the base for all textured objects that are rendered to the screen
    /// 
    /// A sprite can be created directly from an image like this:
    /// 
    /// ```js
    /// let sprite = PIXI.Sprite.from('assets/image.png');
    /// ```
    /// 
    /// The more efficient way to create sprites is using a {@link PIXI.Spritesheet},
    /// as swapping base textures when rendering to the screen is inefficient.
    /// 
    /// ```js
    /// PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
    /// 
    /// function setup() {
    ///    let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
    ///    let sprite = new PIXI.Sprite(sheet.textures["image.png"]);
    ///    ...
    /// }
    /// ```
    type [<AllowNullLiteral>] SpriteStatic =
        [<Emit "new $0($1...)">] abstract Create: ?texture: PIXI.Texture -> Sprite
        abstract fromImage: unit -> PIXI.Sprite
        abstract fromSVG: unit -> PIXI.Sprite
        abstract fromCanvas: unit -> PIXI.Sprite
        abstract fromVideo: unit -> PIXI.Sprite
        abstract fromFrame: unit -> PIXI.Sprite
        /// <summary>Helper function that creates a new sprite based on the source you provide.
        /// The source can be - frame id, image url, video url, canvas element, video element, base texture</summary>
        /// <param name="source">Source to create texture from</param>
        /// <param name="options">See {</param>
        //abstract from: source: U5<float, string, PIXI.Texture, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement> * ?options: obj -> PIXI.Sprite
        abstract from: source: string * ?options: obj -> PIXI.Sprite
        abstract from: source: PIXI.Texture * ?options: obj -> PIXI.Sprite
        abstract from: source: HTMLCanvasElement * ?options: obj -> PIXI.Sprite
        abstract from: source: HTMLVideoElement * ?options: obj -> PIXI.Sprite

    module AnimatedSprite =

        type [<AllowNullLiteral>] FrameObject =
            abstract texture: PIXI.Texture with get, set
            abstract time: float with get, set

    /// An AnimatedSprite is a simple way to display an animation depicted by a list of textures.
    /// 
    /// ```js
    /// let alienImages = ["image_sequence_01.png","image_sequence_02.png","image_sequence_03.png","image_sequence_04.png"];
    /// let textureArray = [];
    /// 
    /// for (let i=0; i < 4; i++)
    /// {
    ///       let texture = PIXI.Texture.from(alienImages[i]);
    ///       textureArray.push(texture);
    /// };
    /// 
    /// let animatedSprite = new PIXI.AnimatedSprite(textureArray);
    /// ```
    /// 
    /// The more efficient and simpler way to create an animated sprite is using a {@link PIXI.Spritesheet}
    /// containing the animation definitions:
    /// 
    /// ```js
    /// PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
    /// 
    /// function setup() {
    ///    let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
    ///    animatedSprite = new PIXI.AnimatedSprite(sheet.animations["image_sequence"]);
    ///    ...
    /// }
    /// ```
    type [<AllowNullLiteral>] AnimatedSprite =
        inherit PIXI.Sprite
        /// The speed that the AnimatedSprite will play at. Higher is faster, lower is slower.
        abstract animationSpeed: float with get, set
        /// Whether or not the animate sprite repeats after playing.
        abstract loop: bool with get, set
        /// Update anchor to [Texture's defaultAnchor]{@link PIXI.Texture#defaultAnchor} when frame changes.
        /// 
        /// Useful with [sprite sheet animations]{@link PIXI.Spritesheet#animations} created with tools.
        /// Changing anchor for each frame allows to pin sprite origin to certain moving feature
        /// of the frame (e.g. left foot).
        /// 
        /// Note: Enabling this will override any previously set `anchor` on each frame change.
        abstract updateAnchor: bool with get, set
        /// (unit->unit) to call when an AnimatedSprite finishes playing.
        abstract onComplete: (ResizeArray<obj option> -> obj option) with get, set
        /// (unit->unit) to call when an AnimatedSprite changes which texture is being rendered.
        abstract onFrameChange: (ResizeArray<obj option> -> obj option) with get, set
        /// (unit->unit) to call when `loop` is true, and an AnimatedSprite is played and loops around to start again.
        abstract onLoop: (ResizeArray<obj option> -> obj option) with get, set
        /// Indicates if the AnimatedSprite is currently playing.
        abstract playing: bool
        /// Stops the AnimatedSprite.
        abstract stop: unit -> unit
        /// Plays the AnimatedSprite.
        abstract play: unit -> unit
        /// <summary>Stops the AnimatedSprite and goes to a specific frame.</summary>
        /// <param name="frameNumber">- Frame index to stop at.</param>
        abstract gotoAndStop: frameNumber: float -> unit
        /// <summary>Goes to a specific frame and begins playing the AnimatedSprite.</summary>
        /// <param name="frameNumber">- Frame index to start at.</param>
        abstract gotoAndPlay: frameNumber: float -> unit
        /// <summary>Stops the AnimatedSprite and destroys it.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value.</param>
        abstract destroy: ?options: AnimatedSpriteDestroyOptions -> unit
        /// The total number of frames in the AnimatedSprite. This is the same as number of textures
        /// assigned to the AnimatedSprite.
        abstract totalFrames: float
        /// The array of textures used for this AnimatedSprite.
        abstract textures: ResizeArray<PIXI.Texture> with get, set
        /// The AnimatedSprites current frame index.
        abstract currentFrame: float
        /// The blend mode to be applied to the sprite. Apply a value of `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// The shader that will be used to render the sprite. Set to null to remove a current shader.
        abstract shader: U2<PIXI.Filter, PIXI.Shader> with get, set
        /// Cached tint value so we can tell when the tint is changed.
        /// Value is used for 2d CanvasRenderer.
        abstract _cachedTint: float with get, set
        /// Plugin that is responsible for rendering this element.
        /// Allows to customize the rendering process without overriding '_render' & '_renderCanvas' methods.
        abstract pluginName: string with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        /// calculates worldTransform * vertices, store it in vertexData
        abstract calculateVertices: unit -> unit
        /// calculates worldTransform * vertices for a non texture with a trim. store it in vertexTrimmedData
        /// This is used to ensure that the true width and height of a trimmed texture is respected
        abstract calculateTrimmedVertices: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The webgl renderer to use.</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// Updates the bounds of the sprite.
        abstract _calculateBounds: unit -> unit
        /// <summary>Gets the local bounds of the sprite object.</summary>
        /// <param name="rect">- The output rectangle.</param>
        abstract getLocalBounds: ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Tests if a point is inside this sprite</summary>
        /// <param name="point">- the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The width of the sprite, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the sprite, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// The anchor sets the origin point of the text. The default value is taken from the {@link PIXI.Texture|Texture}
        /// and passed to the constructor.
        /// 
        /// The default is `(0,0)`, this means the text's origin is the top left.
        /// 
        /// Setting the anchor to `(0.5,0.5)` means the text's origin is centered.
        /// 
        /// Setting the anchor to `(1,1)` would mean the text's origin point will be the bottom right corner.
        /// 
        /// If you pass only single parameter, it will set both x and y to the same value as shown in the example below.
        abstract anchor: PIXI.ObservablePoint with get, set
        /// The tint applied to the sprite. This is a hex value.
        /// A value of 0xFFFFFF will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the sprite is using
        abstract texture: PIXI.Texture with get, set
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] AnimatedSpriteDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// An AnimatedSprite is a simple way to display an animation depicted by a list of textures.
    /// 
    /// ```js
    /// let alienImages = ["image_sequence_01.png","image_sequence_02.png","image_sequence_03.png","image_sequence_04.png"];
    /// let textureArray = [];
    /// 
    /// for (let i=0; i < 4; i++)
    /// {
    ///       let texture = PIXI.Texture.from(alienImages[i]);
    ///       textureArray.push(texture);
    /// };
    /// 
    /// let animatedSprite = new PIXI.AnimatedSprite(textureArray);
    /// ```
    /// 
    /// The more efficient and simpler way to create an animated sprite is using a {@link PIXI.Spritesheet}
    /// containing the animation definitions:
    /// 
    /// ```js
    /// PIXI.Loader.shared.add("assets/spritesheet.json").load(setup);
    /// 
    /// function setup() {
    ///    let sheet = PIXI.Loader.shared.resources["assets/spritesheet.json"].spritesheet;
    ///    animatedSprite = new PIXI.AnimatedSprite(sheet.animations["image_sequence"]);
    ///    ...
    /// }
    /// ```
    type [<AllowNullLiteral>] AnimatedSpriteStatic =
        [<Emit "new $0($1...)">] abstract Create: textures: U2<ResizeArray<PIXI.Texture>, ResizeArray<PIXI.AnimatedSprite.FrameObject>> * ?autoUpdate: bool -> AnimatedSprite
        /// <summary>A short hand way of creating an AnimatedSprite from an array of frame ids.</summary>
        /// <param name="frames">- The array of frames ids the AnimatedSprite will use as its texture frames.</param>
        abstract fromFrames: frames: ResizeArray<string> -> AnimatedSprite
        /// <summary>A short hand way of creating an AnimatedSprite from an array of image ids.</summary>
        /// <param name="images">- The array of image urls the AnimatedSprite will use as its texture frames.</param>
        abstract fromImages: images: ResizeArray<string> -> AnimatedSprite

    /// A tiling sprite is a fast way of rendering a tiling image
    type [<AllowNullLiteral>] TilingSprite =
        inherit PIXI.Sprite
        /// Tile transform
        abstract tileTransform: PIXI.Transform with get, set
        /// matrix that is applied to UV to get the coords in Texture normalized space to coords in BaseTexture space
        abstract uvMatrix: PIXI.TextureMatrix with get, set
        /// Plugin that is responsible for rendering this element.
        /// Allows to customize the rendering process without overriding '_render' method.
        abstract pluginName: string with get, set
        /// Whether or not anchor affects uvs
        abstract uvRespectAnchor: bool with get, set
        /// Changes frame clamping in corresponding textureTransform, shortcut
        /// Change to -0.5 to add a pixel to the edge, recommended for transparent trimmed textures in atlas
        abstract clampMargin: float with get, set
        /// The scaling of the image that is being tiled
        abstract tileScale: PIXI.ObservablePoint with get, set
        /// The offset of the image that is being tiled
        abstract tilePosition: PIXI.ObservablePoint with get, set
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// Updates the bounds of the tiling sprite.
        abstract _calculateBounds: unit -> unit
        /// <summary>Gets the local bounds of the sprite object.</summary>
        /// <param name="rect">- The output rectangle.</param>
        abstract getLocalBounds: rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Checks if a point is inside this tiling sprite.</summary>
        /// <param name="point">- the point to check</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// <summary>Destroys this sprite and optionally its texture and children</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?options: TilingSpriteDestroyOptions -> unit
        /// The width of the sprite, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the TilingSprite, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// The blend mode to be applied to the sprite. Apply a value of `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// The shader that will be used to render the sprite. Set to null to remove a current shader.
        abstract shader: U2<PIXI.Filter, PIXI.Shader> with get, set
        /// Cached tint value so we can tell when the tint is changed.
        /// Value is used for 2d CanvasRenderer.
        abstract _cachedTint: float with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        /// calculates worldTransform * vertices, store it in vertexData
        abstract calculateVertices: unit -> unit
        /// calculates worldTransform * vertices for a non texture with a trim. store it in vertexTrimmedData
        /// This is used to ensure that the true width and height of a trimmed texture is respected
        abstract calculateTrimmedVertices: unit -> unit
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The anchor sets the origin point of the text. The default value is taken from the {@link PIXI.Texture|Texture}
        /// and passed to the constructor.
        /// 
        /// The default is `(0,0)`, this means the text's origin is the top left.
        /// 
        /// Setting the anchor to `(0.5,0.5)` means the text's origin is centered.
        /// 
        /// Setting the anchor to `(1,1)` would mean the text's origin point will be the bottom right corner.
        /// 
        /// If you pass only single parameter, it will set both x and y to the same value as shown in the example below.
        abstract anchor: PIXI.ObservablePoint with get, set
        /// The tint applied to the sprite. This is a hex value.
        /// A value of 0xFFFFFF will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the sprite is using
        abstract texture: PIXI.Texture with get, set
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] TilingSpriteDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// A tiling sprite is a fast way of rendering a tiling image
    type [<AllowNullLiteral>] TilingSpriteStatic =
        abstract from: source: U5<float, string, PIXI.Texture, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement> * ?options: obj -> PIXI.Sprite
        abstract fromFrame: unit -> PIXI.Sprite
        abstract fromImage: unit -> PIXI.Sprite
        [<Emit "new $0($1...)">] abstract Create: texture: PIXI.Texture * ?width: float * ?height: float -> TilingSprite
        /// <summary>Helper function that creates a new tiling sprite based on the source you provide.
        /// The source can be - frame id, image url, video url, canvas element, video element, base texture</summary>
        /// <param name="source">- Source to create texture from</param>
        /// <param name="width">- the width of the tiling sprite</param>
        /// <param name="height">- the height of the tiling sprite</param>
        abstract from: source: U5<float, string, PIXI.Texture, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement> * width: float * height: float -> PIXI.TilingSprite
        /// <summary>Helper function that creates a tiling sprite that will use a texture from the TextureCache based on the frameId
        /// The frame ids are created when a Texture packer file has been loaded</summary>
        /// <param name="frameId">- The frame Id of the texture in the cache</param>
        /// <param name="width">- the width of the tiling sprite</param>
        /// <param name="height">- the height of the tiling sprite</param>
        abstract fromFrame: frameId: string * width: float * height: float -> PIXI.TilingSprite
        /// <summary>Helper function that creates a sprite that will contain a texture based on an image url
        /// If the image is not in the texture cache it will be loaded</summary>
        /// <param name="imageId">- The image url of the texture</param>
        /// <param name="width">- the width of the tiling sprite</param>
        /// <param name="height">- the height of the tiling sprite</param>
        /// <param name="options">- See {</param>
        abstract fromImage: imageId: string * width: float * height: float * ?options: obj -> PIXI.TilingSprite

    /// WebGL renderer plugin for tiling sprites
    type [<AllowNullLiteral>] TilingSpriteRenderer =
        inherit PIXI.ObjectRenderer
        /// <param name="ts">tilingSprite to be rendered</param>
        abstract render: ts: PIXI.TilingSprite -> unit
        /// Starts the renderer and sets the shader
        abstract start: unit -> unit
        /// Stops the renderer
        abstract stop: unit -> unit
        /// Stub method for rendering content and emptying the current batch.
        abstract flush: unit -> unit
        /// The renderer this manager works for.
        abstract renderer: PIXI.Renderer with get, set
        /// <summary>Generic method called when there is a WebGL context change.</summary>
        /// <param name="gl">new webgl context</param>
        abstract contextChange: gl: WebGLRenderingContext -> unit
        /// Generic destroy methods to be overridden by the subclass
        abstract destroy: unit -> unit

    /// WebGL renderer plugin for tiling sprites
    type [<AllowNullLiteral>] TilingSpriteRendererStatic =
        [<Emit "new $0($1...)">] abstract Create: renderer: PIXI.Renderer -> TilingSpriteRenderer

    /// Utility class for maintaining reference to a collection
    /// of Textures on a single Spritesheet.
    /// 
    /// To access a sprite sheet from your code pass its JSON data file to Pixi's loader:
    /// 
    /// ```js
    /// PIXI.Loader.shared.add("images/spritesheet.json").load(setup);
    /// 
    /// function setup() {
    ///    let sheet = PIXI.Loader.shared.resources["images/spritesheet.json"].spritesheet;
    ///    ...
    /// }
    /// ```
    /// With the `sheet.textures` you can create Sprite objects,`sheet.animations` can be used to create an AnimatedSprite.
    /// 
    /// Sprite sheets can be packed using tools like {@link https://codeandweb.com/texturepacker|TexturePacker},
    /// {@link https://renderhjs.net/shoebox/|Shoebox} or {@link https://github.com/krzysztof-o/spritesheet.js|Spritesheet.js}.
    /// Default anchor points (see {@link PIXI.Texture#defaultAnchor}) and grouping of animation sprites are currently only
    /// supported by TexturePacker.
    type [<AllowNullLiteral>] Spritesheet =
        /// Reference to ths source texture
        abstract baseTexture: PIXI.BaseTexture with get, set
        /// A map containing all textures of the sprite sheet.
        /// Can be used to create a {@link PIXI.Sprite|Sprite}:
        /// ```js
        /// new PIXI.Sprite(sheet.textures["image.png"]);
        /// ```
        abstract textures: obj option with get, set
        /// A map containing the textures for each animation.
        /// Can be used to create an {@link PIXI.AnimatedSprite|AnimatedSprite}:
        /// ```js
        /// new PIXI.AnimatedSprite(sheet.animations["anim_name"])
        /// ```
        abstract animations: obj option with get, set
        /// Reference to the original JSON data.
        abstract data: obj option with get, set
        /// The resolution of the spritesheet.
        abstract resolution: float with get, set
        /// <summary>Parser spritesheet from loaded data. This is done asynchronously
        /// to prevent creating too many Texture within a single process.</summary>
        /// <param name="callback">- Callback when complete returns
        /// a map of the Textures for this spritesheet.</param>
        abstract parse: callback: (ResizeArray<obj option> -> obj option) -> unit
        /// <summary>Destroy Spritesheet and don't use after this.</summary>
        /// <param name="destroyBase">Whether to destroy the base texture as well</param>
        abstract destroy: ?destroyBase: bool -> unit

    /// Utility class for maintaining reference to a collection
    /// of Textures on a single Spritesheet.
    /// 
    /// To access a sprite sheet from your code pass its JSON data file to Pixi's loader:
    /// 
    /// ```js
    /// PIXI.Loader.shared.add("images/spritesheet.json").load(setup);
    /// 
    /// function setup() {
    ///    let sheet = PIXI.Loader.shared.resources["images/spritesheet.json"].spritesheet;
    ///    ...
    /// }
    /// ```
    /// With the `sheet.textures` you can create Sprite objects,`sheet.animations` can be used to create an AnimatedSprite.
    /// 
    /// Sprite sheets can be packed using tools like {@link https://codeandweb.com/texturepacker|TexturePacker},
    /// {@link https://renderhjs.net/shoebox/|Shoebox} or {@link https://github.com/krzysztof-o/spritesheet.js|Spritesheet.js}.
    /// Default anchor points (see {@link PIXI.Texture#defaultAnchor}) and grouping of animation sprites are currently only
    /// supported by TexturePacker.
    type [<AllowNullLiteral>] SpritesheetStatic =
        [<Emit "new $0($1...)">] abstract Create: baseTexture: PIXI.BaseTexture * data: obj option * ?resolutionFilename: string -> Spritesheet
        /// The maximum number of Textures to build per process.
        abstract BATCH_SIZE: float with get, set

    /// {@link PIXI.Loader Loader} middleware for loading texture atlases that have been created with
    /// TexturePacker or similar JSON-based spritesheet.
    /// 
    /// This middleware automatically generates Texture resources.
    type [<AllowNullLiteral>] SpritesheetLoader =
        inherit PIXI.ILoaderPlugin

    /// {@link PIXI.Loader Loader} middleware for loading texture atlases that have been created with
    /// TexturePacker or similar JSON-based spritesheet.
    /// 
    /// This middleware automatically generates Texture resources.
    type [<AllowNullLiteral>] SpritesheetLoaderStatic =
        /// <summary>Called after a resource is loaded.</summary>
        /// <param name="resource"></param>
        /// <param name="next"></param>
        abstract ``use``: resource: PIXI.LoaderResource * next: (ResizeArray<obj option> -> obj option) -> unit
        /// <summary>Get the spritesheets root path</summary>
        /// <param name="resource">- Resource to check path</param>
        /// <param name="baseUrl">- Base root url</param>
        abstract getResourcePath: resource: PIXI.LoaderResource * baseUrl: string -> unit

    /// A Text Object will create a line or multiple lines of text.
    /// 
    /// The text is created using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// 
    /// The primary advantage of this class over BitmapText is that you have great control over the style of the next,
    /// which you can change at runtime.
    /// 
    /// The primary disadvantages is that each piece of text has it's own texture, which can use more memory.
    /// When text changes, this texture has to be re-generated and re-uploaded to the GPU, taking up time.
    /// 
    /// To split a line you can use '\n' in your text string, or, on the `style` object,
    /// change its `wordWrap` property to true and and give the `wordWrapWidth` property a value.
    /// 
    /// A Text can be created directly from a string and a style object,
    /// which can be generated [here](https://pixijs.io/pixi-text-style).
    /// 
    /// ```js
    /// let text = new PIXI.Text('This is a PixiJS text',{fontFamily : 'Arial', fontSize: 24, fill : 0xff1010, align : 'center'});
    /// ```
    type [<AllowNullLiteral>] Text =
        inherit PIXI.Sprite
        /// The canvas element that everything is drawn to
        abstract canvas: Browser.Types.HTMLCanvasElement with get, set
        /// The canvas 2d context that everything is drawn with
        abstract context: CanvasRenderingContext2D with get, set
        /// The resolution / device pixel ratio of the canvas.
        /// This is set to automatically match the renderer resolution by default, but can be overridden by setting manually.
        abstract _resolution: float with get, set
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Gets the local bounds of the text object.</summary>
        /// <param name="rect">- The output rectangle.</param>
        abstract getLocalBounds: rect: PIXI.Rectangle -> PIXI.Rectangle
        /// calculates the bounds of the Text as a rectangle. The bounds calculation takes the worldTransform into account.
        abstract _calculateBounds: unit -> unit
        /// <summary>Destroys this text object.
        /// Note* Unlike a Sprite, a Text object will automatically destroy its baseTexture and texture as
        /// the majority of the time the texture will not be shared with any other Sprites.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?options: TextDestroyOptions -> unit
        /// The width of the Text, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Text, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Set the style of the text. Set up an event listener to listen for changes on the style
        /// object and mark the text as dirty.
        abstract style: U2<obj option, PIXI.TextStyle> with get, set
        /// Set the copy for the text object. To split a line you can use '\n'.
        abstract text: string with get, set
        /// The resolution / device pixel ratio of the canvas.
        /// This is set to automatically match the renderer resolution by default, but can be overridden by setting manually.
        abstract resolution: float with get, set
        /// The blend mode to be applied to the sprite. Apply a value of `PIXI.BLEND_MODES.NORMAL` to reset the blend mode.
        abstract blendMode: float with get, set
        /// The shader that will be used to render the sprite. Set to null to remove a current shader.
        abstract shader: U2<PIXI.Filter, PIXI.Shader> with get, set
        /// Cached tint value so we can tell when the tint is changed.
        /// Value is used for 2d CanvasRenderer.
        abstract _cachedTint: float with get, set
        /// Plugin that is responsible for rendering this element.
        /// Allows to customize the rendering process without overriding '_render' & '_renderCanvas' methods.
        abstract pluginName: string with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        /// calculates worldTransform * vertices, store it in vertexData
        abstract calculateVertices: unit -> unit
        /// calculates worldTransform * vertices for a non texture with a trim. store it in vertexTrimmedData
        /// This is used to ensure that the true width and height of a trimmed texture is respected
        abstract calculateTrimmedVertices: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The webgl renderer to use.</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// <summary>Tests if a point is inside this sprite</summary>
        /// <param name="point">- the point to test</param>
        abstract containsPoint: point: PIXI.Point -> bool
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// The anchor sets the origin point of the text. The default value is taken from the {@link PIXI.Texture|Texture}
        /// and passed to the constructor.
        /// 
        /// The default is `(0,0)`, this means the text's origin is the top left.
        /// 
        /// Setting the anchor to `(0.5,0.5)` means the text's origin is centered.
        /// 
        /// Setting the anchor to `(1,1)` would mean the text's origin point will be the bottom right corner.
        /// 
        /// If you pass only single parameter, it will set both x and y to the same value as shown in the example below.
        abstract anchor: PIXI.ObservablePoint with get, set
        /// The tint applied to the sprite. This is a hex value.
        /// A value of 0xFFFFFF will remove any tint effect.
        abstract tint: float with get, set
        /// The texture that the sprite is using
        abstract texture: PIXI.Texture with get, set
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Updates the transform on all children of this container for rendering
        abstract updateTransform: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] TextDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// A Text Object will create a line or multiple lines of text.
    /// 
    /// The text is created using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// 
    /// The primary advantage of this class over BitmapText is that you have great control over the style of the next,
    /// which you can change at runtime.
    /// 
    /// The primary disadvantages is that each piece of text has it's own texture, which can use more memory.
    /// When text changes, this texture has to be re-generated and re-uploaded to the GPU, taking up time.
    /// 
    /// To split a line you can use '\n' in your text string, or, on the `style` object,
    /// change its `wordWrap` property to true and and give the `wordWrapWidth` property a value.
    /// 
    /// A Text can be created directly from a string and a style object,
    /// which can be generated [here](https://pixijs.io/pixi-text-style).
    /// 
    /// ```js
    /// let text = new PIXI.Text('This is a PixiJS text',{fontFamily : 'Arial', fontSize: 24, fill : 0xff1010, align : 'center'});
    /// ```
    type [<AllowNullLiteral>] TextStatic =
        [<Emit "new $0($1...)">] abstract Create: text: string * ?style: U2<obj option, PIXI.TextStyle> * ?canvas: Browser.Types.HTMLCanvasElement -> Text

    type [<AllowNullLiteral>] IFontMetrics =
        abstract ascent: float with get, set
        abstract descent: float with get, set
        abstract fontSize: float with get, set

    /// The TextMetrics object represents the measurement of a block of text with a specified style.
    /// 
    /// ```js
    /// let style = new PIXI.TextStyle({fontFamily : 'Arial', fontSize: 24, fill : 0xff1010, align : 'center'})
    /// let textMetrics = PIXI.TextMetrics.measureText('Your text', style)
    /// ```
    type [<AllowNullLiteral>] TextMetrics =
        /// The text that was measured
        abstract text: string with get, set
        /// The style that was measured
        abstract style: PIXI.TextStyle with get, set
        /// The measured width of the text
        abstract width: float with get, set
        /// The measured height of the text
        abstract height: float with get, set
        /// An array of lines of the text broken by new lines and wrapping is specified in style
        abstract lines: ResizeArray<string> with get, set
        /// An array of the line widths for each line matched to `lines`
        abstract lineWidths: ResizeArray<float> with get, set
        /// The measured line height for this style
        abstract lineHeight: float with get, set
        /// The maximum line width for all measured lines
        abstract maxLineWidth: float with get, set
        /// The font properties object from TextMetrics.measureFont
        abstract fontProperties: PIXI.IFontMetrics with get, set

    /// The TextMetrics object represents the measurement of a block of text with a specified style.
    /// 
    /// ```js
    /// let style = new PIXI.TextStyle({fontFamily : 'Arial', fontSize: 24, fill : 0xff1010, align : 'center'})
    /// let textMetrics = PIXI.TextMetrics.measureText('Your text', style)
    /// ```
    type [<AllowNullLiteral>] TextMetricsStatic =
        [<Emit "new $0($1...)">] abstract Create: text: string * style: PIXI.TextStyle * width: float * height: float * lines: ResizeArray<string> * lineWidths: ResizeArray<float> * lineHeight: float * maxLineWidth: float * fontProperties: obj option -> TextMetrics
        /// <summary>Measures the supplied string of text and returns a Rectangle.</summary>
        /// <param name="text">- the text to measure.</param>
        /// <param name="style">- the text style to use for measuring</param>
        /// <param name="wordWrap">- optional override for if word-wrap should be applied to the text.</param>
        /// <param name="canvas">- optional specification of the canvas to use for measuring.</param>
        abstract measureText: text: string * style: PIXI.TextStyle * ?wordWrap: bool * ?canvas: Browser.Types.HTMLCanvasElement -> PIXI.TextMetrics
        /// <summary>Calculates the ascent, descent and fontSize of a given font-style</summary>
        /// <param name="font">- String representing the style of the font</param>
        abstract measureFont: font: string -> PIXI.IFontMetrics
        /// <summary>Clear font metrics in metrics cache.</summary>
        /// <param name="font">- font name. If font name not set then clear cache for all fonts.</param>
        abstract clearMetrics: ?font: string -> unit
        /// String used for calculate font metrics.
        /// These characters are all tall to help calculate the height required for text.
        abstract METRICS_STRING: string with get, set
        /// Baseline symbol for calculate font metrics.
        abstract BASELINE_SYMBOL: string with get, set
        /// Baseline multiplier for calculate font metrics.
        abstract BASELINE_MULTIPLIER: float with get, set

    /// A TextStyle Object contains information to decorate a Text objects.
    /// 
    /// An instance can be shared between multiple Text objects; then changing the style will update all text objects using it.
    /// 
    /// A tool can be used to generate a text style [here](https://pixijs.io/pixi-text-style).
    type [<AllowNullLiteral>] TextStyle =
        /// Creates a new TextStyle object with the same values as this one.
        /// Note that the only the properties of the object are cloned.
        abstract clone: unit -> PIXI.TextStyle
        /// Resets all properties to the defaults specified in TextStyle.prototype._default
        abstract reset: unit -> unit
        /// Alignment for multiline text ('left', 'center' or 'right'), does not affect single line text
        abstract align: string with get, set
        /// Indicates if lines can be wrapped within words, it needs wordWrap to be set to true
        abstract breakWords: bool with get, set
        /// Set a drop shadow for the text
        abstract dropShadow: bool with get, set
        /// Set alpha for the drop shadow
        abstract dropShadowAlpha: float with get, set
        /// Set a angle of the drop shadow
        abstract dropShadowAngle: float with get, set
        /// Set a shadow blur radius
        abstract dropShadowBlur: float with get, set
        /// A fill style to be used on the dropshadow e.g 'red', '#00FF00'
        abstract dropShadowColor: U2<string, float> with get, set
        /// Set a distance of the drop shadow
        abstract dropShadowDistance: float with get, set
        /// A canvas fillstyle that will be used on the text e.g 'red', '#00FF00'.
        /// Can be an array to create a gradient eg ['#000000','#FFFFFF']
        /// {@link https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fillStyle|MDN}
        abstract fill: U6<string, ResizeArray<string>, float, ResizeArray<float>, CanvasGradient, CanvasPattern> with get, set
        /// If fill is an array of colours to create a gradient, this can change the type/direction of the gradient.
        /// See {@link PIXI.TEXT_GRADIENT}
        abstract fillGradientType: float with get, set
        /// If fill is an array of colours to create a gradient, this array can set the stop points
        /// (numbers between 0 and 1) for the color, overriding the default behaviour of evenly spacing them.
        abstract fillGradientStops: ResizeArray<float> with get, set
        /// The font family
        abstract fontFamily: U2<string, ResizeArray<string>> with get, set
        /// The font size
        /// (as a number it converts to px, but as a string, equivalents are '26px','20pt','160%' or '1.6em')
        abstract fontSize: U2<float, string> with get, set
        /// The font style
        /// ('normal', 'italic' or 'oblique')
        abstract fontStyle: string with get, set
        /// The font variant
        /// ('normal' or 'small-caps')
        abstract fontVariant: string with get, set
        /// The font weight
        /// ('normal', 'bold', 'bolder', 'lighter' and '100', '200', '300', '400', '500', '600', '700', 800' or '900')
        abstract fontWeight: string with get, set
        /// The amount of spacing between letters, default is 0
        abstract letterSpacing: float with get, set
        /// The line height, a number that represents the vertical space that a letter uses
        abstract lineHeight: float with get, set
        /// The space between lines
        abstract leading: float with get, set
        /// The lineJoin property sets the type of corner created, it can resolve spiked text issues.
        /// Default is 'miter' (creates a sharp corner).
        abstract lineJoin: string with get, set
        /// The miter limit to use when using the 'miter' lineJoin mode
        /// This can reduce or increase the spikiness of rendered text.
        abstract miterLimit: float with get, set
        /// Occasionally some fonts are cropped. Adding some padding will prevent this from happening
        /// by adding padding to all sides of the text.
        abstract padding: float with get, set
        /// A canvas fillstyle that will be used on the text stroke
        /// e.g 'blue', '#FCFF00'
        abstract stroke: U2<string, float> with get, set
        /// A number that represents the thickness of the stroke.
        /// Default is 0 (no stroke)
        abstract strokeThickness: float with get, set
        /// The baseline of the text that is rendered.
        abstract textBaseline: string with get, set
        /// Trim transparent borders
        abstract trim: bool with get, set
        /// How newlines and spaces should be handled.
        /// Default is 'pre' (preserve, preserve).
        /// 
        ///   value       | New lines     |   Spaces
        ///   ---         | ---           |   ---
        /// 'normal'     | Collapse      |   Collapse
        /// 'pre'        | Preserve      |   Preserve
        /// 'pre-line'   | Preserve      |   Collapse
        abstract whiteSpace: string with get, set
        /// Indicates if word wrap should be used
        abstract wordWrap: bool with get, set
        /// The width at which text will wrap, it needs wordWrap to be set to true
        abstract wordWrapWidth: float with get, set
        /// Generates a font style string to use for `TextMetrics.measureFont()`.
        abstract toFontString: unit -> string

    /// A TextStyle Object contains information to decorate a Text objects.
    /// 
    /// An instance can be shared between multiple Text objects; then changing the style will update all text objects using it.
    /// 
    /// A tool can be used to generate a text style [here](https://pixijs.io/pixi-text-style).
    type [<AllowNullLiteral>] TextStyleStatic =
        [<Emit "new $0($1...)">] abstract Create: ?style: TextStyleStaticStyle -> TextStyle

    type [<AllowNullLiteral>] TextStyleStaticStyle =
        abstract align: string option with get, set
        abstract breakWords: bool option with get, set
        abstract dropShadow: bool option with get, set
        abstract dropShadowAlpha: float option with get, set
        abstract dropShadowAngle: float option with get, set
        abstract dropShadowBlur: float option with get, set
        abstract dropShadowColor: U2<string, float> option with get, set
        abstract dropShadowDistance: float option with get, set
        abstract fill: U6<string, ResizeArray<string>, float, ResizeArray<float>, CanvasGradient, CanvasPattern> option with get, set
        abstract fillGradientType: float option with get, set
        abstract fillGradientStops: ResizeArray<float> option with get, set
        abstract fontFamily: U2<string, ResizeArray<string>> option with get, set
        abstract fontSize: U2<float, string> option with get, set
        abstract fontStyle: string option with get, set
        abstract fontVariant: string option with get, set
        abstract fontWeight: string option with get, set
        abstract leading: float option with get, set
        abstract letterSpacing: float option with get, set
        abstract lineHeight: float option with get, set
        abstract lineJoin: string option with get, set
        abstract miterLimit: float option with get, set
        abstract padding: float option with get, set
        abstract stroke: U2<string, float> option with get, set
        abstract strokeThickness: float option with get, set
        abstract trim: bool option with get, set
        abstract textBaseline: string option with get, set
        abstract whiteSpace: bool option with get, set
        abstract wordWrap: bool option with get, set
        abstract wordWrapWidth: float option with get, set

    /// {@link PIXI.Loader Loader} middleware for loading
    /// bitmap-based fonts suitable for using with {@link PIXI.BitmapText}.
    type [<AllowNullLiteral>] BitmapFontLoader =
        inherit PIXI.ILoaderPlugin

    /// {@link PIXI.Loader Loader} middleware for loading
    /// bitmap-based fonts suitable for using with {@link PIXI.BitmapText}.
    type [<AllowNullLiteral>] BitmapFontLoaderStatic =
        /// <summary>Register a BitmapText font from loader resource.</summary>
        /// <param name="resource">- Loader resource.</param>
        /// <param name="texture">- Reference to texture.</param>
        abstract parse: resource: PIXI.LoaderResource * texture: PIXI.Texture -> unit
        /// Called when the plugin is installed.
        abstract add: unit -> unit
        /// <summary>Called after a resource is loaded.</summary>
        /// <param name="resource"></param>
        /// <param name="next"></param>
        abstract ``use``: resource: PIXI.LoaderResource * next: (ResizeArray<obj option> -> obj option) -> unit

    /// A BitmapText object will create a line or multiple lines of text using bitmap font.
    /// 
    /// The primary advantage of this class over Text is that all of your textures are pre-generated and loading,
    /// meaning that rendering is fast, and changing text has no performance implications.
    /// 
    /// The primary disadvantage is that you need to preload the bitmap font assets, and thus the styling is set in stone.
    /// Supporting character sets other than latin, such as CJK languages, may be impractical due to the number of characters.
    /// 
    /// To split a line you can use '\n', '\r' or '\r\n' in your string.
    /// 
    /// You can generate the fnt files using
    /// http://www.angelcode.com/products/bmfont/ for Windows or
    /// http://www.bmglyph.com/ for Mac.
    /// 
    /// A BitmapText can only be created when the font is loaded.
    /// 
    /// ```js
    /// // in this case the font is in a file called 'desyrel.fnt'
    /// let bitmapText = new PIXI.BitmapText("text using a fancy font!", {font: "35px Desyrel", align: "right"});
    /// ```
    type [<AllowNullLiteral>] BitmapText =
        inherit PIXI.Container
        /// The dirty state of this object.
        abstract dirty: bool with get, set
        /// If true PixiJS will Math.floor() x/y values when rendering, stopping pixel interpolation.
        /// Advantages can include sharper image quality (like text) and faster rendering on canvas.
        /// The main disadvantage is movement of objects may appear less smooth.
        /// To set the global default, change {@link PIXI.settings.ROUND_PIXELS}
        abstract roundPixels: bool with get, set
        /// Validates text before calling parent's getLocalBounds
        abstract getLocalBounds: unit -> PIXI.Rectangle
        /// The tint of the BitmapText object.
        abstract tint: float with get, set
        /// The alignment of the BitmapText object.
        abstract align: string with get, set
        /// The anchor sets the origin point of the text.
        /// 
        /// The default is `(0,0)`, this means the text's origin is the top left.
        /// 
        /// Setting the anchor to `(0.5,0.5)` means the text's origin is centered.
        /// 
        /// Setting the anchor to `(1,1)` would mean the text's origin point will be the bottom right corner.
        abstract anchor: U2<PIXI.Point, float> with get, set
        /// The font descriptor of the BitmapText object.
        abstract font: obj option with get, set
        /// The text of the BitmapText object.
        abstract text: string with get, set
        /// The max width of this bitmap text in pixels. If the text provided is longer than the
        /// value provided, line breaks will be automatically inserted in the last whitespace.
        /// Disable by setting the value to 0.
        abstract maxWidth: float with get, set
        /// The max line height. This is useful when trying to use the total height of the Text,
        /// i.e. when trying to vertically align.
        abstract maxLineHeight: float
        /// The width of the overall text, different from fontSize,
        /// which is defined in the style object.
        abstract textWidth: float
        /// Additional space between characters.
        abstract letterSpacing: float with get, set
        /// The height of the overall text, different from fontSize,
        /// which is defined in the style object.
        abstract textHeight: float
        /// <param name="renderer">Instance of renderer</param>
        abstract renderWebGL: renderer: PIXI.Renderer -> unit
        /// <param name="renderer">Instance of renderer</param>
        abstract renderAdvancedWebGL: renderer: PIXI.Renderer -> unit
        /// The array of children of this container.
        abstract children: ResizeArray<PIXI.DisplayObject>
        /// If set to true, the container will sort its children by zIndex value
        /// when updateTransform() is called, or manually if sortChildren() is called.
        /// 
        /// This actually changes the order of elements in the array, so should be treated
        /// as a basic solution that is not performant compared to other solutions,
        /// such as @link https://github.com/pixijs/pixi-display
        /// 
        /// Also be aware of that this may not work nicely with the addChildAt() function,
        /// as the zIndex sorting may cause the child to automatically sorted to another position.
        abstract sortableChildren: bool with get, set
        /// Should children be sorted by zIndex at the next updateTransform call.
        /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
        abstract sortDirty: bool with get, set
        /// Overridable method that can be used by Container subclasses whenever the children array is modified
        abstract onChildrenChange: unit -> unit
        /// <summary>Adds one or more children to the container.
        /// 
        /// Multiple items can be added like so: `myContainer.addChild(thingOne, thingTwo, thingThree)`</summary>
        /// <param name="child">- The DisplayObject(s) to add to the container</param>
        abstract addChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown</summary>
        /// <param name="child">- The child to add</param>
        /// <param name="index">- The index to place the child in</param>
        abstract addChildAt: child: PIXI.DisplayObject * index: float -> PIXI.DisplayObject
        /// <summary>Swaps the position of 2 Display Objects within this container.</summary>
        /// <param name="child">- First display object to swap</param>
        /// <param name="child2">- Second display object to swap</param>
        abstract swapChildren: child: PIXI.DisplayObject * child2: PIXI.DisplayObject -> unit
        /// <summary>Returns the index position of a child DisplayObject instance</summary>
        /// <param name="child">- The DisplayObject instance to identify</param>
        abstract getChildIndex: child: PIXI.DisplayObject -> float
        /// <summary>Changes the position of an existing child in the display object container</summary>
        /// <param name="child">- The child DisplayObject instance for which you want to change the index number</param>
        /// <param name="index">- The resulting index number for the child display object</param>
        abstract setChildIndex: child: PIXI.DisplayObject * index: float -> unit
        /// <summary>Returns the child at the specified index</summary>
        /// <param name="index">- The index to get the child at</param>
        abstract getChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes one or more children from the container.</summary>
        /// <param name="child">- The DisplayObject(s) to remove</param>
        abstract removeChild: [<ParamArray>] child: ResizeArray<PIXI.DisplayObject> -> PIXI.DisplayObject
        /// <summary>Removes a child from the specified index position.</summary>
        /// <param name="index">- The index to get the child from</param>
        abstract removeChildAt: index: float -> PIXI.DisplayObject
        /// <summary>Removes all children from this container that are within the begin and end indexes.</summary>
        /// <param name="beginIndex">- The beginning position.</param>
        /// <param name="endIndex">- The ending position. Default value is size of the container.</param>
        abstract removeChildren: ?beginIndex: float * ?endIndex: float -> ResizeArray<PIXI.DisplayObject>
        /// Sorts children by zIndex. Previous order is mantained for 2 children with the same zIndex.
        abstract sortChildren: unit -> unit
        /// Recalculates the bounds of the container.
        abstract calculateBounds: unit -> unit
        /// Recalculates the bounds of the object. Override this to
        /// calculate the bounds of the specific object (not including children).
        abstract _calculateBounds: unit -> unit
        /// <summary>Renders the object using the WebGL renderer</summary>
        /// <param name="renderer">- The renderer</param>
        abstract render: renderer: PIXI.Renderer -> unit
        /// <summary>Render the object using the WebGL renderer and advanced features.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract renderAdvanced: renderer: PIXI.Renderer -> unit
        /// <summary>To be overridden by the subclasses.</summary>
        /// <param name="renderer">- The renderer</param>
        abstract _render: renderer: PIXI.Renderer -> unit
        /// <summary>Removes all internal references and listeners as well as removes children from the display list.
        /// Do not use a Container after calling `destroy`.</summary>
        /// <param name="options">- Options parameter. A boolean will act as if all options
        /// have been set to that value</param>
        abstract destroy: ?options: BitmapTextDestroyOptions -> unit
        /// The width of the Container, setting this will actually modify the scale to achieve the value set
        abstract width: float with get, set
        /// The height of the Container, setting this will actually modify the scale to achieve the value set
        abstract height: float with get, set
        /// Determines if the children to the displayObject can be clicked/touched
        /// Setting this to false allows PixiJS to bypass a recursive `hitTest` function
        abstract interactiveChildren: bool with get, set
        /// <summary>Returns the display object in the container.</summary>
        /// <param name="name">- Instance name.</param>
        abstract getChildByName: name: string -> PIXI.DisplayObject
        /// Flag for if the object is accessible. If true AccessibilityManager will overlay a
        ///   shadow div with attributes set
        abstract accessible: bool with get, set
        /// Sets the title attribute of the shadow div
        /// If accessibleTitle AND accessibleHint has not been this will default to 'displayObject [tabIndex]'
        abstract accessibleTitle: string with get, set
        /// Sets the aria-label attribute of the shadow div
        abstract accessibleHint: string with get, set
        abstract _accessibleActive: bool with get, set
        abstract _accessibleDiv: bool with get, set
        /// World transform and local transform of this object.
        /// This will become read-only later, please do not assign anything there unless you know what are you doing.
        abstract transform: PIXI.Transform with get, set
        /// The opacity of the object.
        abstract alpha: float with get, set
        /// The visibility of the object. If false the object will not be drawn, and
        /// the updateTransform function will not be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds or call updateTransform manually.
        abstract visible: bool with get, set
        /// Can this object be rendered, if false the object will not be drawn but the updateTransform
        /// methods will still be called.
        /// 
        /// Only affects recursive calls from parent. You can ask for bounds manually.
        abstract renderable: bool with get, set
        /// The display object container that contains this display object.
        abstract parent: PIXI.Container
        /// The multiplied alpha of the displayObject.
        abstract worldAlpha: float
        /// Which index in the children array the display component was before the previous zIndex sort.
        /// Used by containers to help sort objects with the same zIndex, by using previous array index as the decider.
        abstract _lastSortedIndex: float with get, set
        /// The zIndex of the displayObject.
        /// A higher value will mean it will be rendered on top of other displayObjects within the same container.
        abstract _zIndex: float with get, set
        /// The area the filter is applied to. This is used as more of an optimization
        /// rather than figuring out the dimensions of the displayObject each frame you can set this rectangle.
        /// 
        /// Also works as an interaction mask.
        abstract filterArea: PIXI.Rectangle with get, set
        /// Sets the filters for the displayObject.
        /// * IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
        /// To remove filters simply set this property to `'null'`.
        abstract filters: ResizeArray<PIXI.Filter> with get, set
        /// The bounds object, this is used to calculate and store the bounds of the displayObject.
        abstract _bounds: PIXI.Bounds with get, set
        /// The original, cached mask of the object.
        abstract _mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// If the object has been destroyed via destroy(). If true, it should not be used.
        abstract _destroyed: bool with get, set
        /// used to fast check if a sprite is.. a sprite!
        abstract isSprite: bool with get, set
        abstract _tempDisplayObjectParent: PIXI.DisplayObject with get, set
        /// Recursively updates transform of all objects from the root to this one
        /// internal function for toLocal()
        abstract _recursivePostUpdateTransform: unit -> unit
        /// <summary>Retrieves the bounds of the displayObject as a rectangle object.</summary>
        /// <param name="skipUpdate">- Setting to `true` will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        /// <param name="rect">- Optional rectangle to store the result of the bounds calculation.</param>
        abstract getBounds: ?skipUpdate: bool * ?rect: PIXI.Rectangle -> PIXI.Rectangle
        /// <summary>Calculates the global position of the display object.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform.</param>
        abstract toGlobal: position: PIXI.IPoint * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Calculates the local position of the display object relative to another point.</summary>
        /// <param name="position">- The world origin to calculate from.</param>
        /// <param name="from">- The DisplayObject to calculate the global position from.</param>
        /// <param name="point">- A Point object in which to store the value, optional
        /// (otherwise will create a new Point).</param>
        /// <param name="skipUpdate">- Should we skip the update transform</param>
        abstract toLocal: position: PIXI.IPoint * ?from: PIXI.DisplayObject * ?point: PIXI.IPoint * ?skipUpdate: bool -> PIXI.IPoint
        /// <summary>Set the parent Container of this DisplayObject.</summary>
        /// <param name="container">- The Container to add this DisplayObject to.</param>
        abstract setParent: container: PIXI.Container -> PIXI.Container
        /// <summary>Convenience function to set the position, scale, skew and pivot at once.</summary>
        /// <param name="x">- The X position</param>
        /// <param name="y">- The Y position</param>
        /// <param name="scaleX">- The X scale value</param>
        /// <param name="scaleY">- The Y scale value</param>
        /// <param name="rotation">- The rotation</param>
        /// <param name="skewX">- The X skew value</param>
        /// <param name="skewY">- The Y skew value</param>
        /// <param name="pivotX">- The X pivot value</param>
        /// <param name="pivotY">- The Y pivot value</param>
        abstract setTransform: ?x: float * ?y: float * ?scaleX: float * ?scaleY: float * ?rotation: float * ?skewX: float * ?skewY: float * ?pivotX: float * ?pivotY: float -> PIXI.DisplayObject
        /// The position of the displayObject on the x axis relative to the local coordinates of the parent.
        /// An alias to position.x
        abstract x: float with get, set
        /// The position of the displayObject on the y axis relative to the local coordinates of the parent.
        /// An alias to position.y
        abstract y: float with get, set
        /// Current transform of the object based on world (parent) factors.
        abstract worldTransform: PIXI.Matrix
        /// Current transform of the object based on local factors: position, scale, other stuff.
        abstract localTransform: PIXI.Matrix
        /// The coordinate of the object relative to the local coordinates of the parent.
        /// Assignment by value since pixi-v4.
        abstract position: PIXI.IPoint with get, set
        /// The scale factor of the object.
        /// Assignment by value since pixi-v4.
        abstract scale: PIXI.IPoint with get, set
        /// The pivot point of the displayObject that it rotates around.
        /// Assignment by value since pixi-v4.
        abstract pivot: PIXI.IPoint with get, set
        /// The skew factor for the object in radians.
        /// Assignment by value since pixi-v4.
        abstract skew: PIXI.ObservablePoint with get, set
        /// The rotation of the object in radians.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract rotation: float with get, set
        /// The angle of the object in degrees.
        /// 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
        abstract angle: float with get, set
        /// The zIndex of the displayObject.
        /// If a container has the sortableChildren property set to true, children will be automatically
        /// sorted by zIndex value; a higher value will mean it will be moved towards the end of the array,
        /// and thus rendered on top of other displayObjects within the same container.
        abstract zIndex: float with get, set
        /// Indicates if the object is globally visible.
        abstract worldVisible: bool
        /// Sets a mask for the displayObject. A mask is an object that limits the visibility of an
        /// object to the shape of the mask applied to it. In PixiJS a regular mask must be a
        /// {@link PIXI.Graphics} or a {@link PIXI.Sprite} object. This allows for much faster masking in canvas as it
        /// utilities shape clipping. To remove a mask, set this property to `null`.
        /// 
        /// For sprite mask both alpha and red channel are used. Black mask is the same as transparent mask.
        abstract mask: U2<PIXI.Graphics, PIXI.Sprite> with get, set
        /// DisplayObject default updateTransform, does not update children of container.
        /// Will crash if there's no parent element.
        abstract displayObjectUpdateTransform: unit -> unit
        /// Enable interaction events for the DisplayObject. Touch, pointer and mouse
        /// events will not be emitted unless `interactive` is set to `true`.
        abstract interactive: bool with get, set
        /// Interaction shape. Children will be hit first, then this shape will be checked.
        /// Setting this will cause this shape to be checked in hit tests rather than the displayObject's bounds.
        abstract hitArea: U5<PIXI.Rectangle, PIXI.Circle, PIXI.Ellipse, PIXI.Polygon, PIXI.RoundedRectangle> with get, set
        /// If enabled, the mouse cursor use the pointer behavior when hovered over the displayObject if it is interactive
        /// Setting this changes the 'cursor' property to `'pointer'`.
        abstract buttonMode: bool with get, set
        /// This defines what cursor mode is used when the mouse cursor
        /// is hovered over the displayObject.
        abstract cursor: string with get, set
        /// Set this to true if you want this display object to be cached as a bitmap.
        /// This basically takes a snap shot of the display object as it is at that moment. It can
        /// provide a performance benefit for complex static displayObjects.
        /// To remove simply set this property to `false`
        /// 
        /// IMPORTANT GOTCHA - Make sure that all your textures are preloaded BEFORE setting this property to true
        /// as it will take a snapshot of what is currently there. If the textures have not loaded then they will not appear.
        abstract cacheAsBitmap: bool with get, set
        /// The instance name of the object.
        abstract name: string with get, set
        /// <summary>Returns the global position of the displayObject. Does not depend on object scale, rotation and pivot.</summary>
        /// <param name="point">- The point to write the global value to.</param>
        /// <param name="skipUpdate">- Setting to true will stop the transforms of the scene graph from
        /// being updated. This means the calculation returned MAY be out of date BUT will give you a
        /// nice performance boost.</param>
        abstract getGlobalPosition: ?point: PIXI.Point * ?skipUpdate: bool -> PIXI.Point

    type [<AllowNullLiteral>] BitmapTextDestroyOptions =
        abstract children: bool option with get, set
        abstract texture: bool option with get, set
        abstract baseTexture: bool option with get, set

    /// A BitmapText object will create a line or multiple lines of text using bitmap font.
    /// 
    /// The primary advantage of this class over Text is that all of your textures are pre-generated and loading,
    /// meaning that rendering is fast, and changing text has no performance implications.
    /// 
    /// The primary disadvantage is that you need to preload the bitmap font assets, and thus the styling is set in stone.
    /// Supporting character sets other than latin, such as CJK languages, may be impractical due to the number of characters.
    /// 
    /// To split a line you can use '\n', '\r' or '\r\n' in your string.
    /// 
    /// You can generate the fnt files using
    /// http://www.angelcode.com/products/bmfont/ for Windows or
    /// http://www.bmglyph.com/ for Mac.
    /// 
    /// A BitmapText can only be created when the font is loaded.
    /// 
    /// ```js
    /// // in this case the font is in a file called 'desyrel.fnt'
    /// let bitmapText = new PIXI.BitmapText("text using a fancy font!", {font: "35px Desyrel", align: "right"});
    /// ```
    type [<AllowNullLiteral>] BitmapTextStatic =
        [<Emit "new $0($1...)">] abstract Create: text: string * style: BitmapTextStaticStyle -> BitmapText
        /// <summary>Register a bitmap font with data and a texture.</summary>
        /// <param name="xml">- The XML document data.</param>
        /// <param name="textures">- List of textures for each page.
        /// If providing an object, the key is the `<page>` element's `file` attribute in the FNT file.</param>
        abstract registerFont: xml: XMLDocument * textures: U3<TypeLiteral_13, PIXI.Texture, ResizeArray<PIXI.Texture>> -> obj option

    type [<AllowNullLiteral>] BitmapTextStaticStyle =
        abstract font: TypeLiteral_14 with get, set
        abstract align: string option with get, set
        abstract tint: float option with get, set

    /// A Ticker class that runs an update loop that other objects listen to.
    /// 
    /// This class is composed around listeners meant for execution on the next requested animation frame.
    /// Animation frames are requested only when necessary, e.g. When the ticker is started and the emitter has listeners.
    type [<AllowNullLiteral>] Ticker =
        /// Whether or not this ticker should invoke the method
        /// {@link PIXI.Ticker#start} automatically
        /// when a listener is added.
        abstract autoStart: bool with get, set
        /// Scalar time value from last frame to this frame.
        /// This value is capped by setting {@link PIXI.Ticker#minFPS}
        /// and is scaled with {@link PIXI.Ticker#speed}.
        /// **Note:** The cap may be exceeded by scaling.
        abstract deltaTime: float with get, set
        /// Scaler time elapsed in milliseconds from last frame to this frame.
        /// This value is capped by setting {@link PIXI.Ticker#minFPS}
        /// and is scaled with {@link PIXI.Ticker#speed}.
        /// **Note:** The cap may be exceeded by scaling.
        /// If the platform supports DOMHighResTimeStamp,
        /// this value will have a precision of 1 µs.
        /// Defaults to target frame time
        abstract deltaMS: float with get, set
        /// Time elapsed in milliseconds from last frame to this frame.
        /// Opposed to what the scalar {@link PIXI.Ticker#deltaTime}
        /// is based, this value is neither capped nor scaled.
        /// If the platform supports DOMHighResTimeStamp,
        /// this value will have a precision of 1 µs.
        /// Defaults to target frame time
        abstract elapsedMS: float with get, set
        /// The last time {@link PIXI.Ticker#update} was invoked.
        /// This value is also reset internally outside of invoking
        /// update, but only when a new animation frame is requested.
        /// If the platform supports DOMHighResTimeStamp,
        /// this value will have a precision of 1 µs.
        abstract lastTime: float with get, set
        /// Factor of current {@link PIXI.Ticker#deltaTime}.
        abstract speed: float with get, set
        /// Whether or not this ticker has been started.
        /// `true` if {@link PIXI.Ticker#start} has been called.
        /// `false` if {@link PIXI.Ticker#stop} has been called.
        /// While `false`, this value may change to `true` in the
        /// event of {@link PIXI.Ticker#autoStart} being `true`
        /// and a listener is added.
        abstract started: bool with get, set
        /// <summary>Register a handler for tick events. Calls continuously unless
        /// it is removed or the ticker is stopped.</summary>
        /// <param name="fn">- The listener function to be added for updates</param>
        /// <param name="context">- The listener context</param>
        /// <param name="priority">- The priority for emitting</param>
        abstract add: fn: (ResizeArray<obj option> -> obj option) * ?context: obj * ?priority: float -> PIXI.Ticker
        /// <summary>Add a handler for the tick event which is only execute once.</summary>
        /// <param name="fn">- The listener function to be added for one update</param>
        /// <param name="context">- The listener context</param>
        /// <param name="priority">- The priority for emitting</param>
        abstract addOnce: fn: (ResizeArray<obj option> -> obj option) * ?context: obj * ?priority: float -> PIXI.Ticker
        /// <summary>Removes any handlers matching the function and context parameters.
        /// If no handlers are left after removing, then it cancels the animation frame.</summary>
        /// <param name="fn">- The listener function to be removed</param>
        /// <param name="context">- The listener context to be removed</param>
        abstract remove: fn: (ResizeArray<obj option> -> obj option) * ?context: obj -> PIXI.Ticker
        /// Starts the ticker. If the ticker has listeners
        /// a new animation frame is requested at this point.
        abstract start: unit -> unit
        /// Stops the ticker. If the ticker has requested
        /// an animation frame it is canceled at this point.
        abstract stop: unit -> unit
        /// Destroy the ticker and don't use after this. Calling
        /// this method removes all references to internal events.
        abstract destroy: unit -> unit
        /// <summary>Triggers an update. An update entails setting the
        /// current {@link PIXI.Ticker#elapsedMS},
        /// the current {@link PIXI.Ticker#deltaTime},
        /// invoking all listeners with current deltaTime,
        /// and then finally setting {@link PIXI.Ticker#lastTime}
        /// with the value of currentTime that was provided.
        /// This method will be called automatically by animation
        /// frame callbacks if the ticker instance has been started
        /// and listeners are added.</summary>
        /// <param name="currentTime">- the current time of execution</param>
        abstract update: ?currentTime: float -> unit
        /// The frames per second at which this ticker is running.
        /// The default is approximately 60 in most modern browsers.
        /// **Note:** This does not factor in the value of
        /// {@link PIXI.Ticker#speed}, which is specific
        /// to scaling {@link PIXI.Ticker#deltaTime}.
        abstract FPS: float
        /// Manages the maximum amount of milliseconds allowed to
        /// elapse between invoking {@link PIXI.Ticker#update}.
        /// This value is used to cap {@link PIXI.Ticker#deltaTime},
        /// but does not effect the measured value of {@link PIXI.Ticker#FPS}.
        /// When setting this property it is clamped to a value between
        /// `0` and `PIXI.settings.TARGET_FPMS * 1000`.
        abstract minFPS: float with get, set
        /// Manages the minimum amount of milliseconds allowed to
        /// elapse between invoking {@link PIXI.Ticker#update}.
        /// This will effect the measured value of {@link PIXI.Ticker#FPS}.
        /// When setting this property it is clamped to a value between
        /// `1` and `TARGET_FPMS * 1000`.
        abstract maxFPS: float with get, set

    /// A Ticker class that runs an update loop that other objects listen to.
    /// 
    /// This class is composed around listeners meant for execution on the next requested animation frame.
    /// Animation frames are requested only when necessary, e.g. When the ticker is started and the emitter has listeners.
    type [<AllowNullLiteral>] TickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Ticker
        /// The shared ticker instance used by {@link PIXI.AnimatedSprite} and by
        /// {@link PIXI.VideoResource} to update animation frames / video textures.
        /// 
        /// It may also be used by {@link PIXI.Application} if created with the `sharedTicker` option property set to true.
        /// 
        /// The property {@link PIXI.Ticker#autoStart} is set to `true` for this instance.
        /// Please follow the examples for usage, including how to opt-out of auto-starting the shared ticker.
        abstract shared: PIXI.Ticker with get, set
        /// The system ticker instance used by {@link PIXI.interaction.InteractionManager} and by
        /// {@link PIXI.BasePrepare} for core timing functionality that shouldn't usually need to be paused,
        /// unlike the `shared` ticker which drives visual animations and rendering which may want to be paused.
        /// 
        /// The property {@link PIXI.Ticker#autoStart} is set to `true` for this instance.
        abstract system: PIXI.Ticker with get, set

    /// Middleware for for Application Ticker.
    type [<AllowNullLiteral>] TickerPlugin =
        interface end

    /// Middleware for for Application Ticker.
    type [<AllowNullLiteral>] TickerPluginStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TickerPlugin

    module Utils =
        let [<Import("mixins","pixi.js/PIXI/utils")>] mixins: Mixins.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract getSvgSize: unit -> unit
            /// Skips the hello message of renderers that are created after this is run.
            abstract skipHello: unit -> unit
            /// <summary>Logs out the version and renderer information for this running instance of PIXI.
            /// If you don't want to see this message you can run `PIXI.utils.skipHello()` before
            /// creating your renderer. Keep in mind that doing that will forever makes you a jerk face.</summary>
            /// <param name="type">- The string renderer type to log.</param>
            abstract sayHello: ``type``: string -> unit
            /// Helper for checking for WebGL support.
            abstract isWebGLSupported: unit -> bool
            /// <summary>Converts a hexadecimal color number to an [R, G, B] array of normalized floats (numbers from 0.0 to 1.0).</summary>
            /// <param name="hex">- The hexadecimal number to convert</param>
            /// <param name="out">If supplied, this array will be used rather than returning a new one</param>
            abstract hex2rgb: hex: float * ?out: ResizeArray<float> -> ResizeArray<float>
            /// <summary>Converts a hexadecimal color number to a string.</summary>
            /// <param name="hex">- Number in hex (e.g., `0xffffff`)</param>
            abstract hex2string: hex: float -> string
            /// <summary>Converts a hexadecimal string to a hexadecimal color number.</summary>
            /// <param name="The">string color (e.g., `"#ffffff"`)</param>
            abstract string2hex: The: string -> float
            /// <summary>Converts a color as an [R, G, B] array of normalized floats to a hexadecimal number.</summary>
            /// <param name="rgb">- Array of numbers where all values are normalized floats from 0.0 to 1.0.</param>
            abstract rgb2hex: rgb: ResizeArray<float> -> float
            abstract premultiplyBlendMode: ResizeArray<ResizeArray<float>>
            /// <summary>changes blendMode according to texture format</summary>
            /// <param name="blendMode">supposed blend mode</param>
            /// <param name="premultiplied">whether source is premultiplied</param>
            abstract correctBlendMode: blendMode: float * premultiplied: bool -> float
            /// <summary>combines rgb and alpha to out array</summary>
            /// <param name="rgb">input rgb</param>
            /// <param name="alpha">alpha param</param>
            /// <param name="out">output</param>
            /// <param name="premultiply">do premultiply it</param>
            abstract premultiplyRgba: rgb: U2<float [], ResizeArray<float>> * alpha: float * ?out: float [] * ?premultiply: bool -> float []
            /// <summary>premultiplies tint</summary>
            /// <param name="tint">integer RGB</param>
            /// <param name="alpha">floating point alpha (0.0-1.0)</param>
            abstract premultiplyTint: tint: float * alpha: float -> float
            /// <summary>converts integer tint and float alpha to vec4 form, premultiplies by default</summary>
            /// <param name="tint">input tint</param>
            /// <param name="alpha">alpha param</param>
            /// <param name="out">output</param>
            /// <param name="premultiply">do premultiply it</param>
            abstract premultiplyTintToRgba: tint: float * alpha: float * ?out: float [] * ?premultiply: bool -> float []
            /// <summary>Rounds to next power of two.</summary>
            /// <param name="v">input value</param>
            abstract isPow2: v: float -> float
            /// <summary>Computes ceil of log base 2</summary>
            /// <param name="v">input value</param>
            abstract log2: v: float -> float
            /// <summary>Remove items from a javascript array without generating garbage</summary>
            /// <param name="arr">Array to remove elements from</param>
            /// <param name="startIdx">starting index</param>
            /// <param name="removeCount">how many to remove</param>
            abstract removeItems: arr: ResizeArray<obj option> * startIdx: float * removeCount: float -> unit
            /// <summary>Returns sign of number</summary>
            /// <param name="n">- the number to check the sign of</param>
            abstract sign: n: float -> float
            /// Gets the next unique identifier
            abstract uid: unit -> float
            abstract isMobile: TypeLiteral_07
            abstract EventEmitter: EventEmitterStatic
            /// <summary>A polygon triangulation library</summary>
            /// <param name="vertices">- A flat array of vertex coordinates</param>
            /// <param name="holes">- An array of hole indices</param>
            /// <param name="dimensions">The number of coordinates per vertex in the input array</param>
            abstract earcut: vertices: ResizeArray<float> * ?holes: ResizeArray<float> * ?dimensions: float -> ResizeArray<float>
            abstract url: obj option
            /// <summary>Helper for warning developers about deprecated features & settings.
            /// A stack track for warnings is given; useful for tracking-down where
            /// deprecated methods/properties/classes are being used within the code.</summary>
            /// <param name="version">- The version where the feature became deprecated</param>
            /// <param name="message">- Message should include what is deprecated, where, and the new solution</param>
            /// <param name="ignoreDepth">- The number of steps to ignore at the top of the error stack
            /// this is mostly to ignore internal deprecation calls.</param>
            abstract deprecation: version: string * message: string * ?ignoreDepth: float -> unit
            abstract ProgramCache: obj option
            abstract TextureCache: obj option
            abstract BaseTextureCache: obj option
            /// Destroys all texture in the cache
            abstract destroyTextureCache: unit -> unit
            /// Removes all textures from cache, but does not destroy them
            abstract clearTextureCache: unit -> unit
            abstract CanvasRenderTarget: CanvasRenderTargetStatic
            /// <summary>Trim transparent borders from a canvas</summary>
            /// <param name="canvas">- the canvas to trim</param>
            abstract trimCanvas: canvas: Browser.Types.HTMLCanvasElement -> obj option
            /// <summary>Split a data URI into components. Returns undefined if
            /// parameter `dataUri` is not a valid data URI.</summary>
            /// <param name="dataUri">- the data URI to check</param>
            abstract decomposeDataUri: dataUri: string -> PIXI.Utils.DecomposedDataUri option
            /// <summary>get the resolution / device pixel ratio of an asset by looking for the prefix
            /// used by spritesheets and image urls</summary>
            /// <param name="url">- the image path</param>
            /// <param name="defaultValue">- the defaultValue if no filename prefix is set.</param>
            abstract getResolutionOfUrl: url: string * ?defaultValue: float -> float

        module Mixins =

            type [<AllowNullLiteral>] IExports =
                abstract ``mixin``: unit -> unit
                abstract delayMixin: unit -> unit
                abstract performMixins: unit -> unit

        /// A high performance event emitter
        type [<AllowNullLiteral>] EventEmitter =
            /// Return an array listing the events for which the emitter has registered listeners.
            abstract eventNames: unit -> string [] with get
            //abstract eventNames: unit -> Symbol [] with get
            /// <summary>Return the listeners registered for a given event.</summary>
            /// <param name="event">The event name.</param>
            abstract listeners: ``event``: U2<string, Symbol> -> (unit->unit) []
            /// <summary>Return the number of listeners listening to a given event.</summary>
            /// <param name="event">The event name.</param>
            abstract listenerCount: ``event``: U2<string, Symbol> -> float
            /// <summary>Calls each of the listeners registered for a given event.</summary>
            /// <param name="event">The event name.</param>
            /// <param name="args">Arguments that are passed to registered listeners</param>
            abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: ResizeArray<obj option> -> bool
            /// <summary>Add a listener for a given event.</summary>
            /// <param name="event">The event name.</param>
            /// <param name="fn">The listener function.</param>
            /// <param name="context">The context to invoke the listener with.</param>
            abstract on: ``event``: U2<string, Symbol> * fn: (unit->unit) * ?context: obj -> EventEmitter
            /// <summary>Add a one-time listener for a given event.</summary>
            /// <param name="event">The event name.</param>
            /// <param name="fn">The listener function.</param>
            /// <param name="context">The context to invoke the listener with.</param>
            abstract once: ``event``: U2<string, Symbol> * fn: (unit->unit) * ?context: obj -> EventEmitter
            /// <summary>Remove the listeners of a given event.</summary>
            /// <param name="event">The event name.</param>
            /// <param name="fn">Only remove the listeners that match this function.</param>
            /// <param name="context">Only remove the listeners that have this context.</param>
            /// <param name="once">Only remove one-time listeners.</param>
            abstract removeListener: ``event``: U2<string, Symbol> * ?fn: (unit->unit) * ?context: obj * ?once: bool -> EventEmitter
            /// <summary>Remove all listeners, or those of the specified event.</summary>
            /// <param name="event">The event name.</param>
            abstract removeAllListeners: ?``event``: U2<string, Symbol> -> EventEmitter
            /// Alias method for `removeListener`
            abstract off: ``event``: U2<string, Symbol> * ?fn: (unit->unit) * ?context: obj * ?once: bool -> EventEmitter
            /// Alias method for `on`
            abstract addListener: ``event``: U2<string, Symbol> * fn: (unit->unit) * ?context: obj -> EventEmitter

        /// A high performance event emitter
        type [<AllowNullLiteral>] EventEmitterStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> EventEmitter

        /// Creates a Canvas element of the given size to be used as a target for rendering to.
        type [<AllowNullLiteral>] CanvasRenderTarget =
            /// The Canvas object that belongs to this CanvasRenderTarget.
            abstract canvas: Browser.Types.HTMLCanvasElement with get, set
            /// A CanvasRenderingContext2D object representing a two-dimensional rendering context.
            abstract context: CanvasRenderingContext2D with get, set
            /// <summary>Resizes the canvas to the specified width and height.</summary>
            /// <param name="width">- the new width of the canvas</param>
            /// <param name="height">- the new height of the canvas</param>
            abstract resize: width: float * height: float -> unit
            /// Destroys this canvas.
            abstract destroy: unit -> unit
            /// The width of the canvas buffer in pixels.
            abstract width: float with get, set
            /// The height of the canvas buffer in pixels.
            abstract height: float with get, set

        /// Creates a Canvas element of the given size to be used as a target for rendering to.
        type [<AllowNullLiteral>] CanvasRenderTargetStatic =
            [<Emit "new $0($1...)">] abstract Create: width: float * height: float * ?resolution: float -> CanvasRenderTarget

        type [<AllowNullLiteral>] DecomposedDataUri =
            abstract mediaType: string with get, set
            abstract subType: string with get, set
            abstract encoding: string with get, set
            abstract data: string with get, set

        type [<AllowNullLiteral>] TypeLiteral_07 =
            abstract any: bool with get, set
            abstract tablet: bool with get, set
            abstract phone: bool with get, set
            abstract apple: TypeLiteral_05 with get, set
            abstract android: TypeLiteral_06 with get, set
            abstract amazon: TypeLiteral_06 with get, set
            abstract windows: TypeLiteral_06 with get, set

        type [<AllowNullLiteral>] TypeLiteral_06 =
            abstract device: bool with get, set
            abstract tablet: bool with get, set
            abstract phone: bool with get, set

        type [<AllowNullLiteral>] TypeLiteral_05 =
            abstract device: bool with get, set
            abstract tablet: bool with get, set
            abstract phone: bool with get, set
            abstract ipod: bool with get, set

    type [<AllowNullLiteral>] IResourceDictionary =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: index: string -> LoaderResource with get, set

    type [<AllowNullLiteral>] ITextureDictionary =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: index: string -> Texture with get, set

    type [<AllowNullLiteral>] ILoaderOptions =
        abstract crossOrigin: U2<bool, string> option with get, set
        abstract loadType: float option with get, set
        abstract xhrType: string option with get, set
        abstract metadata: TypeLiteral_15 option with get, set

    module LoaderResource =

        type [<AllowNullLiteral>] IExports =
            abstract setExtensionLoadType: extname: string * loadType: float -> unit
            abstract setExtensionXhrType: extname: string * xhrType: string -> unit
            abstract EMPTY_GIF: string

        type [<RequireQualifiedAccess>] STATUS_FLAGS =
            | NONE = 0
            | DATA_URL = 1
            | COMPLETE = 2
            | LOADING = 3

        type [<RequireQualifiedAccess>] TYPE =
            | UNKNOWN = 0
            | JSON = 1
            | XML = 2
            | IMAGE = 3
            | AUDIO = 4
            | VIDEO = 5
            | TEXT = 6

        type [<RequireQualifiedAccess>] LOAD_TYPE =
            | XHR = 1
            | IMAGE = 2
            | AUDIO = 3
            | VIDEO = 4

        type [<StringEnum>] [<RequireQualifiedAccess>] XHR_RESPONSE_TYPE =
            | [<CompiledName "text">] DEFAULT
            | [<CompiledName "arraybuffer">] BUFFER
            | [<CompiledName "blob">] BLOB
            | [<CompiledName "document">] DOCUMENT
            | [<CompiledName "json">] JSON
            | [<CompiledName "text">] TEXT

    type [<AllowNullLiteral>] TypeLiteral_11 =
        abstract INTERACTION: float with get, set
        abstract HIGH: float with get, set
        abstract NORMAL: float with get, set
        abstract LOW: float with get, set
        abstract UTILITY: float with get, set

    type [<AllowNullLiteral>] TypeLiteral_10 =
        abstract LINEAR_VERTICAL: float with get, set
        abstract LINEAR_HORIZONTAL: float with get, set

    type [<AllowNullLiteral>] TypeLiteral_09 =
        abstract POLY: float with get, set
        abstract RECT: float with get, set
        abstract CIRC: float with get, set
        abstract ELIP: float with get, set
        abstract RREC: float with get, set

    type [<AllowNullLiteral>] TypeLiteral_12 =
        abstract accessibility: PIXI.Accessibility.AccessibilityManager with get, set
        abstract extract: PIXI.Extract.Extract with get, set
        abstract interaction: PIXI.Interaction.InteractionManager with get, set
        abstract prepare: PIXI.Prepare.Prepare with get, set

    type [<AllowNullLiteral>] TypeLiteral_08 =
        abstract adaptive: bool with get, set
        abstract maxLength: float with get, set
        abstract minSegments: float with get, set
        abstract maxSegments: float with get, set

    type [<AllowNullLiteral>] TypeLiteral_15 =
        abstract loadElement: U3<Browser.Types.HTMLImageElement, HTMLAudioElement, Browser.Types.HTMLVideoElement> option with get, set
        abstract skipSource: bool option with get, set
        abstract mimeType: U2<string, ResizeArray<string>> option with get, set

    type [<AllowNullLiteral>] TypeLiteral_14 =
        abstract name: string option with get, set
        abstract size: float option with get, set

    type [<AllowNullLiteral>] TypeLiteral_13 =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> PIXI.Texture with get, set

type [<AllowNullLiteral>] SharedArrayBuffer =
    interface end
