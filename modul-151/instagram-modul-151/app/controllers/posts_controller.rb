class PostsController < ApplicationController
  before_action :authenticate_user!
  before_action :find_post, only: [:show, :destroy]

  def index
    @posts = Post.all.limit(10).includes(:photos, :user, :likes).order('created_at desc')
    @post = Post.new
  end

  def create
    @post = current_user.posts.build(post_params)
    if !params[:images]
      redirect_to posts_path
      flash[:alert] = "Please select minimum one picture!"
      return
    end
    if @post.save
      if params[:images]
        params[:images].each do |img|
          @post.photos.create(image: img)
        end
      end

      redirect_to posts_path
      flash[:notice] = "Saved ..."
    else
      flash[:alert] = "Somethin went wrong ..."
      redirect_to posts_path
    end
  end

  def show
    @photos = @post.photos
    @likes = @post.likes.includes(:user)
    @is_like =  @post.is_liked(current_user)
  end

  def destroy
    if @post.user == current_user
      if @post.destroy
        flash[:notice] = "Post deleted!"
      else
        flash[:alert] = "Something went wrong ..."
      end
    else
      flash[:alert] = "You dont have the permission to delete this post!"
    end
    redirect_to root_path
  end

  private

  def find_post
    @post = Post.find_by id: params[:id]

    return if @post
    flash[:danger] = "Post doesn't exist!"
    redirect_to root_path
  end

  def post_params
    params.require(:post).permit :content
  end
end